using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    class StudentInfo
    {
        private string _filePath = "Student Information.json";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string EnrolledCourse { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public void Add(StudentInfo info)
        {
            Random r = new Random();
            info.Id = r.Next(1, 500); //generates id randomly from 1 - 500.
            string data = JsonConvert.SerializeObject(info, Formatting.None); //Serializes the specified object to a JSON string.
            Utility.WriteToTextFile(_filePath, data);
        }
        public StudentInfo Edit(int id)
        {
            StudentInfo obj = new StudentInfo();
            return obj;
        }
        public void Edit(StudentInfo info)
        {
            List<StudentInfo> list = List();
            StudentInfo s = list.Where(x => x.Id == info.Id).FirstOrDefault();
            list.Remove(s);
            list.Add(info);
            string data = JsonConvert.SerializeObject(list, Formatting.None); //converting the list of students to string.
            Utility.WriteToTextFile(_filePath, data, false);
        }
        public void Delete(int id)
        {
            //Invoking the list of student to delete it from its index number
            List<StudentInfo> list = List();
            StudentInfo student = list.Where(x => x.Id == id).FirstOrDefault();
            list.Remove(student);
            int count = list.Count;
            string studentData = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToTextFile(_filePath, studentData, false, count);

        }
        public StudentInfo Detail(int id)
        {
            StudentInfo obj = new StudentInfo();
            return obj;
        }
        public List<StudentInfo> List()
        {
            string d = Utility.ReadFromTextFile(_filePath);
            if (d != null)
            {
               List<StudentInfo> lst = JsonConvert.DeserializeObject<List<StudentInfo>>(d);
               return lst;
            }
            return null;
        }
    }
}
