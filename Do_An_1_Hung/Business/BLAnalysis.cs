using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Do_An_1.DomainClass;

namespace Do_An_1.Business
{
    public class BLAnalysis
    {
        public int ClusterAmount { get; set; }
        public int SubjectAmount { get; set; }
        public int LoopCount { get; set; }
        public List<List<IGrouping<int, Grade>>> Clusters { get; set; }
        public List<MyGrouping<int, Grade>> CentralPoint { get; set; }
        public BLAnalysis()
        {
            using (var ctx = new UniversityContext())
            {
                this.SubjectAmount = ctx.Subjects.Count();
            }
        }
        public BLAnalysis(int clusteramount)
        {
            this.ClusterAmount = clusteramount;
            using (var ctx = new UniversityContext())
            {
                this.SubjectAmount = ctx.Subjects.Count();
            }
        }
        public void CopyPoint(ref MyGrouping<int, Grade> a, IGrouping<int, Grade> b)        //Copy cac gia tri trong variable dang reference type sang 1 variable khac 
        {
            for (int j = 0; j < this.SubjectAmount; j++)
            {
                a.Add(new Grade { });
            }
            int i = 0;
            foreach (var c in b)
            {
                a.ElementAt(i).Mark = c.Mark;
                i++;
            }
        }
        public void ExceptDuplicate(ref int startRan, List<int> listRan, int startingStudentID, int endingStudentID, Random ran)  // Khu truong hop trung ID khi khoi tao central point khi dung khoi tao kmean binh thuong
        {
            foreach (var c in listRan)
            {
                if (startRan == c)
                {
                    startRan = ran.Next(startingStudentID, endingStudentID);
                    ExceptDuplicate(ref startRan, listRan, startingStudentID, endingStudentID, ran);
                }
            }
        }
        public void KmeanPlusPlus(ref List<MyGrouping<int, Grade>> CentralPoint, System.Collections.Generic.List<IGrouping<int, Grade>> pointList)
        {
            Random ran = new Random();      // Khoi tao Student ID bat dau va ket thuc trong danh sach de random vi tri khoi tao
            int startingStudentID = pointList.First().Key;
            int endingStudentID = pointList.Last().Key;

            var temporaryVariable = new MyGrouping<int, Grade>();       // Khoi tao central point dau tien bang cach random
            CentralPoint.Add(temporaryVariable);
            int kmeanPlusPlusInitializePoint = ran.Next(startingStudentID, endingStudentID);
            var TheFisrtPoint = CentralPoint[0];
            CopyPoint(ref TheFisrtPoint, pointList.Single(c => c.Key == kmeanPlusPlusInitializePoint));

            int Count = 1;      // Da ton tai san 1 central point
            while (true)            // Bat dau tim cac central point con lai
            {
                if (Count == ClusterAmount)     // Thoa so luong cluster yeu cau thi break 
                {
                    break;
                }

                List<MyGrouping<double?, Grade>> MinDistanceList = new List<MyGrouping<double?, Grade>>();      // Khoi tao List chua khoang cach be nhat den central point gan nhat cua tat cac cac point
                foreach (var point in pointList)
                {
                    List<double?> Result = new List<double?>(); // List chua khoang cach den tung central point cua 1 diem 
                    for (int i = 0; i < Count; i++)
                    {
                        var temp = 0;
                        Result.Add(temp);
                    }
                    for (int i = 0; i < this.SubjectAmount; i++)        // An gian, cong thuc tinh khoang cach, nhung khong tinh cang bac 2
                    {
                        for (int j = 0; j < Count; j++)
                        {
                            Result[j] += (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark) * (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark);
                        }
                    }

                    double? minResult = Result[0];      // Tim ra khoang cach be nhat
                    for (int i = 0; i < Count; i++)
                    {
                        if (Result[i] < minResult)
                        {
                            minResult = Result[i];
                        }
                    }

                    MyGrouping<double?, Grade> temporaryCentralPoint = new MyGrouping<double?, Grade>(); // khoi tao 1 instance dai dien cho 1 point voi key la khoang cach ngan nhat toi central point gan nhat cua point do
                    temporaryCentralPoint.Key = minResult;
                    for (int j = 0; j < this.SubjectAmount; j++)
                    {
                        temporaryCentralPoint.Add(new Grade { });
                    }
                    int elementCount = 0;
                    foreach (var c in temporaryCentralPoint)
                    {
                        temporaryCentralPoint.ElementAt(elementCount).Mark = point.ElementAt(elementCount).Mark;
                        elementCount++;
                    }
                    MinDistanceList.Add(temporaryCentralPoint);
                }

                IGrouping<double?, Grade> MaxPoint = MinDistanceList.First();       // Sau khi da co duoc ket qua khoang cach cua tung point den central point gan nhat cua no, ta se duyet het tat ca cac khoang cach nay va tim ra khoang cach lon nhat, point tuong ung se tro thanh point tiep theo  
                foreach (var Point in MinDistanceList)                  // key o day chinh la khoang cach giua 1 point va central point gan nhat cua no
                {
                    if (Point.Key > MaxPoint.Key)
                    {
                        MaxPoint = Point;
                    }
                }

                var TemporaryPoint = new MyGrouping<int, Grade>();      // Copy point cac thanh phan trong 1 reference type variable sang 1 variable khac 
                CentralPoint.Add(TemporaryPoint);
                for (int j = 0; j < this.SubjectAmount; j++)
                {
                    CentralPoint[Count].Add(new Grade { });
                }
                int gradeCount = 0;
                foreach (var c in CentralPoint[Count])
                {
                    CentralPoint[Count].ElementAt(gradeCount).Mark = MaxPoint.ElementAt(gradeCount).Mark;
                    gradeCount++;
                }

                Count++; // Them thanh cong 1 central point
            }
            return;
        }

        public int Kmean(bool IsKmeanPlusPlus,string DepartmentName)
        {
            using (var ctx = new UniversityContext())
            {
                foreach( var grade in ctx.Grades)           // kiem tra co gia tri diem nao null khong, neu co se thoat ra khoi thuat toan
                {
                    if(grade.Mark==null)
                    {
                        return 0;
                    }
                }

                List<IGrouping<int, Grade>> pointList = new List<IGrouping<int, Grade>>();
                if (DepartmentName == "All")
                {
                    pointList = ctx.Grades.GroupBy(s => s.StudentID).ToList();         // danh sach tat ca sinh vien va diem so cua tung sinh vien, 1 Point tuc la 1 student    
                }
                else
                {
                    var departmentid = ctx.Departments.FirstOrDefault(s => s.DeparmentName == DepartmentName).DepartmentID;
                    var liststudent = ctx.Students.Where(s => s.DepartmentID == departmentid);
                    var tempPointList = from a in ctx.Grades
                                        join b in liststudent
                                        on a.StudentID equals b.StudentID
                                        select a;
                    pointList = tempPointList.GroupBy(s => s.StudentID).ToList();
                }

                Clusters = new List<List<IGrouping<int, Grade>>>();  // Khai bai List chua cac cluster 
                for (int i = 0; i < ClusterAmount; i++)
                {
                    var Temp = new List<IGrouping<int, Grade>>();
                    Clusters.Add(Temp);
                }

                int startingStudentID = pointList.First().Key;                                  //Khai bao ID bat dau va ID ket thuc trong danh sach sinh vien de random
                int endingStudentID = pointList.Last().Key;
                

                if (IsKmeanPlusPlus == false)
                {
                    Random ran = new Random();
                    List<int> listRan = new List<int>();
                    int StartRan;
                    CentralPoint = new List<MyGrouping<int, Grade>>();             // Khoi tao cac central point trong cac cluster theo cach random thong thuong
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        var Temp = new MyGrouping<int, Grade>();
                        CentralPoint.Add(Temp);
                        StartRan = ran.Next(startingStudentID, endingStudentID);
                        ExceptDuplicate(ref StartRan, listRan, startingStudentID, endingStudentID, ran);
                        listRan.Add(StartRan);
                        var TempPoint = CentralPoint[i];
                        CopyPoint(ref TempPoint, pointList.Single(c => c.Key == StartRan));
                    }
                }
                else
                {
                    CentralPoint = new List<MyGrouping<int, Grade>>();           //  Khoi tao cac central point trong cac cluster theo cach k-mean ++
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        var Temp = new MyGrouping<int, Grade>();
                        CentralPoint.Add(Temp);
                    }
                    var temporaryCentralPoint = CentralPoint;
                    KmeanPlusPlus(ref temporaryCentralPoint, pointList);
                }

                this.LoopCount = 0;
                while (true)
                {
                    Clusters = new List<List<IGrouping<int, Grade>>>();              // Khoi tao lai danh sach Cluter sau moi lan duyet het tat cac phan tu 
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        var Temp = new List<IGrouping<int, Grade>>();
                        Clusters.Add(Temp);
                    }

                    List<MyGrouping<int, Grade>> CompareCentralPoint = new List<MyGrouping<int, Grade>>();  // Khoi tao lai danh sach Temporary Central Point de so sanh voi cac Central Point duoc dieu chinh lai khi duyet het lai tat cac cac phan tu  
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        var Temp = new MyGrouping<int, Grade>();
                        CompareCentralPoint.Add(Temp);
                        var TempPoint = CompareCentralPoint[i];
                        CopyPoint(ref TempPoint, CentralPoint[i]);
                    }

                    foreach (var point in pointList) // Bat dau duyet tung phan tu de tinh xem phan tu do thuoc cluster nao
                    {
                        List<double?> Result = new List<double?>();    // Khoi tao danh sach ket qua de luu khoach cach cua 1 Point lan luot den cac Central Point
                        for (int i = 0; i < ClusterAmount; i++)
                        {
                            var Temp = 0;
                            Result.Add(Temp);
                        }

                        for (int i = 0; i < this.SubjectAmount; i++)        // Tinh theo cong thuc |A1A2| = SQRT( (x1-x2)*((x1-x2) + (y1-y2)*((y1-y2) +... )  // trong do A1 la 1 sinh vien, A2 la central point
                        {
                            for (int j = 0; j < ClusterAmount; j++)
                            {
                                Result[j] += (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark) * (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark);
                            }
                        }
                        for (int i = 0; i < ClusterAmount; i++)
                        {
                            Result[i] = Math.Sqrt(Convert.ToDouble(Result[i]));
                        }

                        double? minResult = Result[0];      // Tim ra khoang cach nho nhat cua phan tu voi cac central point, va gan phan tu thuoc cluster tuong ung
                        int GroupMax = 0;
                        for (int i = 0; i < Result.Count; i++)
                        {
                            if (Result[i] < minResult)
                            {
                                minResult = Result[i];
                                GroupMax = i;
                            }
                        }
                        Clusters[GroupMax].Add(point);
                    }

                    List<double?> elementList = new List<double?>();

                    int count = 0;
                    foreach (var eachCluster in Clusters)     // Moi Cluster 
                    {
                        elementList = new List<double?>();   // Khoi tao danh sach cac phan tu trong 1 Temporary Point de luu gia tri cua central point sau khi tinh lai 
                        for (int i = 0; i < this.SubjectAmount; i++)
                        {
                            var Temp = 0;
                            elementList.Add(Temp);
                        }

                        foreach (var point in eachCluster)    // Moi Point 
                        {
                            int i = 0;
                            foreach (var element in point)      // Moi element trong Point
                            {
                                elementList[i] += element.Mark;
                                i++;
                            }
                        }
                        for (int i = 0; i < elementList.Count; i++)     // Tinh lai gia tri cua central point trong cluster do 
                        {
                            CentralPoint[count].ElementAt(i).Mark = elementList[i] / eachCluster.Count();
                        }
                        count++;
                    }

                    bool flag = true;               // Kiem tra xem co du dieu kien de ket thuc vong lap chua ( neu central point khong thay doi )
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        for (int j = 0; j < this.SubjectAmount; j++)
                        {
                            if (CompareCentralPoint.ElementAt(i).ElementAt(j).Mark != CentralPoint.ElementAt(i).ElementAt(j).Mark)
                            {
                                flag = false;
                                i = ClusterAmount + 100;
                                break;
                            }
                        }
                    }
                    if (flag == true)
                    {
                        break;
                    }
                    this.LoopCount++;
                }
            }
            return 1;
        }        
    }
}
