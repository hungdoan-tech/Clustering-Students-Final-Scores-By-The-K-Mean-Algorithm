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
        static void sinh()
        {
            using (var ctx = new UniversityContext())
            {
                int[] A = new int[] { 2,3,4};
                int[] B = new int[] { 0, 1, 2, 3, 4, 5,6,7};
                Random rand = new Random();

                var var1 = ctx.Students.Where(s => s.StudentID> 17110300 && s.StudentID<=17110399).ToList();
            
                foreach (var c in var1)
                {
                    var var2 = ctx.Grades.Where(s => s.StudentID == c.StudentID).Select(s => s.ClassID);
                    foreach (var item in var2)
                    {
                        int Temp = rand.Next(3);
                        string a;
                        {
                            a = A[Temp].ToString() + "." + B[rand.Next(8)].ToString();
                        }
                        Console.WriteLine( c.StudentID.ToString() + " " + item + " " + a);
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
                    CopyPoint(ref CentralPoint[i] , myList.Single(c => c.Key == StartRan));
                }
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
                string filepath = @"E:\Học lại từ đầu\LearningAgain\test2.txt";
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



