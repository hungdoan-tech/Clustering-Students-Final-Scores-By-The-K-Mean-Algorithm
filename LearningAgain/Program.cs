using LearningAgain.DomainClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LearningAgain
{
    class Program
    {
        const int ClusterAmount = 3;
        static void Main(string[] args)
        {           
            using (var ctx = new UniversityContext())
            {
                //ctx.Departments.Add(new Department() { DepartmentID = 105, DeparmentName = "MTT", PhoneNumber = "234623432" });
                //ctx.SaveChanges();
                //Console.WriteLine("Student saved successfully!");

                //readfile();
                //Console.WriteLine(" Done");
                Kmean();
                Console.ReadLine();
            }
        }
        static void test1()
        {
            using (var ctx = new UniversityContext())
            {
                var var1 = ctx.Subjects.Select(s => s.SubjectID).ToList();
                var var3 = ctx.Students.Select(s => s.StudentID).ToList();
                int count = 0;
                foreach (var c in var1)
                {
                    var var2 = ctx.Classes.Where(s => s.SubjectID == c.ToString()).ToList();
                    List<string> var4 = new List<string>();
                    foreach (var item in var2)
                    {
                        var4.Add(item.ClassID.ToString());
                    }
                    int dieukhien = 0;
                    int i = 0;
                    foreach (var d in var3)
                    {
                        //if (count == 3001)
                        //{
                        //    return;
                        //}
                        if (i != 0 && i % 50 == 0)
                        {
                            dieukhien++;
                        }
                       
                        Console.WriteLine("  new Grade{ StudentID=" + d.ToString() + ",ClassID=" + "'" + var4[dieukhien] + "'" + "},");
                        i++;
                        count++;
                    }
                }
            }
        }
        static void sinh()
        {
            using (var ctx = new UniversityContext())
            {
                int[] A = new int[] { 2,3,4,5};
                int[] C = new int[] { 5, 6, 7 };
                int[] D = new int[] { 7, 8, 9 };
                int[] B1 = new int[] { 0, 1, 2, 3, 4, 5,6,7,8,9};
                int[] B2 = new int[] { 6, 7, 8, 9 };
                Random rand = new Random();


                var var1 = ctx.Students.ToList();
                int count = 0;
                foreach (var c in var1)
                {
                    int chuyen = rand.Next(4);
                    var var2 = ctx.Grades.Where(s => s.StudentID == c.StudentID).Select(s => s.ClassID);
                    foreach (var item in var2)
                    {
                        if (chuyen==0)
                        {
                            int Temp = rand.Next(4);
                            string a;
                            {
                                a = A[Temp].ToString() + "." + B1[rand.Next(10)].ToString();
                            }
                            Console.WriteLine(c.StudentID.ToString() + " " + item + " " + a);
                        }
                        else
                        { if( chuyen == 1)

                            {                               
                                int Temp = rand.Next(3);
                                string a;
                                {
                                    a = D[Temp].ToString() + "." + B2[rand.Next(4)].ToString();
                                }
                                Console.WriteLine(c.StudentID.ToString() + " " + item + " " + a);
                            }
                            else
                            {
                                int Temp = rand.Next(3);
                                string a;
                                {
                                    a = C[Temp].ToString() + "." + B1[rand.Next(10)].ToString();
                                }
                                Console.WriteLine(c.StudentID.ToString() + " " + item + " " + a);
                            }
                        }
                        count++;
                    }
                }
            }
        }   
        static void CopyPoint(ref MyGrouping<int, Grade> a, IGrouping<int, Grade> b)
        {
            for (int j = 0; j < 20; j++)
            {
                a.Add(new Grade { });
            }
            int i = 0;
            foreach( var c in b)
            {
                a.ElementAt(i).Mark = c.Mark;
                i++;
            }
        }
        static void DeQuy(ref int startRan, List<int> listRan, int ViTriBatDau,int ViTriKetThuc, Random ran)
        {
            foreach (var c in listRan)
            {
                if (startRan == c)
                {
                    startRan = ran.Next(ViTriBatDau, ViTriKetThuc);
                    DeQuy(ref startRan, listRan, ViTriBatDau, ViTriKetThuc, ran);
                }
            }
        }
        static void KmeanPlusPlus(ref MyGrouping<int,Grade>[] CentralPoint, System.Collections.Generic.List<IGrouping<int,Grade>> myList)
        {
            Random ran = new Random();
            int ViTriBatDau = myList.First().Key;
            int ViTriKetThuc = myList.Last().Key;
            int Count = 1;
            CentralPoint[0] = new MyGrouping<int, Grade>();
            int vitribatdau = ran.Next(ViTriBatDau, ViTriKetThuc);
            CopyPoint(ref CentralPoint[0], myList.Single(c=> c.Key == vitribatdau));
            while (true)
            {
                List<MyGrouping<double?, Grade>> MinDistanceList = new List<MyGrouping<double?, Grade>>();
                foreach (var point in myList)
                {
                    double?[] ketQua = new double?[Count];
                    for (int i = 0; i < Count; i++)
                    {
                        ketQua[i] = 0;
                    }
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < Count; j++)
                        {
                            ketQua[j] += (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark) * (point.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark);
                        }
                    }

                    double? ketQuaMin = ketQua[0];
                    for (int i = 0; i < Count; i++)
                    {
                        if (ketQua[i] < ketQuaMin)
                        {
                            ketQuaMin = ketQua[i];
                        }
                    }
                    MyGrouping<double?, Grade> Temp = new MyGrouping<double?, Grade>();
                    Temp.Key = ketQuaMin;
                    for (int j = 0; j < 20; j++)
                    {
                        Temp.Add(new Grade { });
                    }
                    int dem = 0;
                    foreach (var c in Temp)
                    {
                        Temp.ElementAt(dem).Mark = point.ElementAt(dem).Mark;
                        dem++;
                    }
                    MinDistanceList.Add(Temp);
                }
                if (Count == ClusterAmount)
                {
                    break;
                }
                IGrouping<double?, Grade> Max = MinDistanceList.First();
                foreach (var c in MinDistanceList)
                {
                    if (c.Key > Max.Key)
                    {
                        Max = c;
                    }
                }
                CentralPoint[Count] = new MyGrouping<int, Grade>();
                for (int j = 0; j < 20; j++)
                {
                    CentralPoint[Count].Add(new Grade { });
                }
                int dem2 = 0;
                foreach (var c in CentralPoint[Count])
                {
                    CentralPoint[Count].ElementAt(dem2).Mark = Max.ElementAt(dem2).Mark;
                    dem2++;
                }                
                Count++;
            }
            return;
        }

        static void Kmean()
        {
            using (var ctx = new UniversityContext())
            {
                var myList = ctx.Grades.GroupBy(s => s.StudentID).ToList();
                var testList = ctx.Grades.ToList();
                List<IGrouping<int, Grade>>[] Group = new List<IGrouping<int, Grade>>[ClusterAmount];

                Random ran = new Random();
                int ViTriBatDau = myList.First().Key;
                int ViTriKetThuc = myList.Last().Key;
                int StartRan;
                List<int> listRan = new List<int>();

                MyGrouping<int, Grade>[] CentralPoint = new MyGrouping<int, Grade>[ClusterAmount];
                for (int i = 0; i < ClusterAmount; i++)
                {
                    CentralPoint[i] = new MyGrouping<int, Grade>();
                    StartRan = ran.Next(ViTriBatDau, ViTriKetThuc);
                    DeQuy(ref StartRan, listRan, ViTriBatDau, ViTriKetThuc, ran);
                    listRan.Add(StartRan);
                    CopyPoint(ref CentralPoint[i], myList.Single(c => c.Key == StartRan));
                }

                //MyGrouping<int, Grade>[] CentralPoint = new MyGrouping<int, Grade>[ClusterAmount];
                //KmeanPlusPlus(ref CentralPoint, myList);

                int SoLan = 0;
                while (true)
                {

                    Group = new List<IGrouping<int, Grade>>[ClusterAmount];
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        Group[i] = new List<IGrouping<int, Grade>>();
                    }

                    MyGrouping<int, Grade>[] CompareCentralPoint = new MyGrouping<int, Grade>[ClusterAmount];
                    for (int i = 0; i < ClusterAmount ; i++)
                    {
                        CompareCentralPoint[i] = new MyGrouping<int, Grade>();
                        CopyPoint(ref CompareCentralPoint[i], CentralPoint[i]);
                    }

                    foreach (var item in myList)
                    {
                        //double?[] tichVoHuong = new double?[ClusterAmount] { 0, 0, 0 };
                        //double? doDaiItem = 0;
                        //double?[] doDaiCentralPoint = new double?[ClusterAmount] { 0, 0, 0};
                        //double?[] ketQua = new double?[ClusterAmount] { 0, 0, 0};

                        //for (int i = 0; i < 20; i++)
                        //{
                        //    for (int j = 0; j < tichVoHuong.Length; j++)
                        //    {
                        //        tichVoHuong[j] += item.ElementAt(i).Mark * CentralPoint[j].ElementAt(i).Mark;
                        //    }

                        //    doDaiItem += item.ElementAt(i).Mark * item.ElementAt(i).Mark;

                        //    for (int j = 0; j < doDaiCentralPoint.Length; j++)
                        //    {
                        //        doDaiCentralPoint[j] += CentralPoint[j].ElementAt(i).Mark * CentralPoint[j].ElementAt(i).Mark;
                        //    }
                        //}
                        //doDaiItem = Math.Sqrt((double)doDaiItem);

                        //for (int j = 0; j < doDaiCentralPoint.Length; j++)
                        //{
                        //    doDaiCentralPoint[j] = Math.Sqrt((double)doDaiCentralPoint[j]);
                        //}

                        //for (int j = 0; j < ketQua.Length; j++)
                        //{
                        //    ketQua[j] = tichVoHuong[j] / (doDaiItem * doDaiCentralPoint[j]);
                        //}

                        double?[] ketQua = new double?[ClusterAmount] { 0, 0, 0};
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < ClusterAmount; j++)
                            {
                                ketQua[j] += (item.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark) * (item.ElementAt(i).Mark - CentralPoint[j].ElementAt(i).Mark);
                            }
                        }

                        for(int i=0;i<ClusterAmount;i++)
                        {
                            ketQua[i] = Math.Sqrt(Convert.ToDouble(ketQua[i]));
                        }
                        double? ketQuaMax = ketQua[0];
                        int GroupMax = 0;
                        for (int i = 0; i < ketQua.Length; i++)
                        {
                            if (ketQua[i] < ketQuaMax)
                            {
                                ketQuaMax = ketQua[i];
                                GroupMax = i;
                            }
                        }
                        Group[GroupMax].Add(item);
                    }
                    
                    double?[] danhSachDiemTam = new double?[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    int count = 0;
                    foreach (var a in Group)
                    {
                        danhSachDiemTam = new double?[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        foreach (var b in a)
                        {
                            int i = 0;
                            foreach (var c in b)
                            {
                                danhSachDiemTam[i] += c.Mark;
                                i++;
                            }
                        }
                        for (int i = 0; i < danhSachDiemTam.Length; i++)
                        {
                            CentralPoint[count].ElementAt(i).Mark = danhSachDiemTam[i] / a.Count();
                        }
                        count++;
                    }
                    bool flag = true;
                    for (int i = 0; i < ClusterAmount; i++)
                    {
                        for (int j = 0; j < 20; j++)
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
                    SoLan++;
                    Console.WriteLine(SoLan);
                }
                for (int i=0; i<ClusterAmount;i++)
                {
                    Console.Write("Cebtral "+ i +" : ");
                    double avg = 0;
                    foreach ( var d in CentralPoint[i])
                    {
                        avg += (double)d.Mark;
                        Console.Write(d.Mark+" ");
                    }
                    avg = avg / 20;
                    Console.Write("       " + avg + "\n");
                }
                Console.WriteLine();
                for (int i = 0; i < Group.Length; i++)
                {
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Danh sach cac sinh vien trong group " + i + " :");
                    foreach (var e in Group.ElementAt(i))
                    {
                        Console.Write(e.Key+"  ");
                       double avg = 0;
                       foreach( var f in e)
                        {
                            avg += (double)f.Mark;
                            Console.Write(f.Mark +" "); 
                        }
                        avg = avg / 20;
                        Console.Write("       "+ avg+"\n");
                    }
                }
            }
        }
        static void readfile()
        {
            using (var ctx = new LearningAgain.UniversityContext())
            {
                Console.WriteLine("Start ");
                string filepath = @"E:\Học lại từ đầu\LearningAgain\test3.txt";
                string[] line;
                int i = 0;
                int phantram = 0;

                if (System.IO.File.Exists(filepath))
                {
                    line = System.IO.File.ReadAllLines(filepath);
                    Console.WriteLine(phantram);
                    foreach (var c in line)
                    {
                        string[] d = new string[3];
                        d = c.Split(new char[] { ' ' });
                        int stu = Convert.ToInt32(d[0]);
                        string cla = d[1];
                        try
                        {
                            ctx.Grades.SingleOrDefault(b => b.StudentID == stu && b.ClassID == cla).Mark= Convert.ToDouble(d[2]);
                        }
                        catch (Exception ex)
                        {
                            Console.Write("Du lieu input chua dung !");
                            Console.WriteLine(ex.Message);
                            break;
                        }
                        i++;
                        if( i!=0 && i%80==0)
                        {
                            phantram++;
                            Console.Clear();
                            Console.Write(phantram);
                        }                             
                    }
                    ctx.SaveChanges();
                }
                else
                {                    
                    Console.WriteLine("File doest not exist");
                }
            }
        }
    }
}



