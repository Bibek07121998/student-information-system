using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class StudentEnrollForm : Form
    {
        public StudentEnrollForm()
        {
            InitializeComponent();
            BindGrid();
            updateBtn.Visible = false;
        }

        private void StudentEnrollForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //validating same email...
            /**for (int row = 0; row < dataGridStudent.Rows.Count; row++)
            {
                for (int col = 0; col < dataGridStudent.Columns.Count; col++)
                {
                    if (dataGridStudent.Rows[row].Cells[col].Value != null
                        && dataGridStudent.Rows[row].Cells[col].Value.Equals(emailTxtBox.Text.Trim()))
                    {
                        MessageBox.Show("Duplicate Values");
                    }
                }
            }**/
            //Validating Text fields.
            if (fNameTxtBox.Text == "" 
                || fNameTxtBox.Text.Any(i => char.IsNumber(i)) 
                || string.IsNullOrWhiteSpace(fNameTxtBox.Text) 
                && fNameTxtBox.Text.Length > 0)
            {
                //fNameTxtBox.BackColor = Color.Red;
                MessageBox.Show("Fill the First name correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fNameTxtBox.Focus();
                return;
            }
            if (lNameTxtBox.Text == "" 
                || lNameTxtBox.Text.Any(i => char.IsNumber(i))
                || string.IsNullOrWhiteSpace(lNameTxtBox.Text) 
                && lNameTxtBox.Text.Length > 0)
            {
                //lNameTxtBox.BackColor = Color.Red;
                MessageBox.Show("Fill the Last name correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lNameTxtBox.Focus();
                return;
            }
            if (contacTxtBox.Text == "" 
                || contacTxtBox.Text.Any(i => char.IsLetter(i))
                || string.IsNullOrWhiteSpace(contacTxtBox.Text) 
                && contacTxtBox.Text.Length > 0)
            {
                //fNameTxtBox.BackColor = Color.Red;
                MessageBox.Show("Fill the contact number correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fNameTxtBox.Focus();
                return;
            }

            if (emailTxtBox.Text == "")
            {
                MessageBox.Show("Fill the email correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emailTxtBox.Focus();
                return;
            }
            
            if (emailTxtBox.Text.Length > 0)
            {
                Regex RegxEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                if (!RegxEmail.IsMatch(emailTxtBox.Text.Trim()))
                {
                    //emailTxtBox.BackColor = Color.Red;
                    MessageBox.Show("Email is not valid", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    emailTxtBox.Focus();
                    return;
                }
            }

            /**if (string.IsNullOrEmpty(emailTxtBox.Text)
                || string.IsNullOrWhiteSpace(contacTxtBox.Text)
                && contacTxtBox.Text.Length > 0)
            {
                Regex RegxEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                if (!RegxEmail.IsMatch(emailTxtBox.Text.Trim()))
                {
                    //emailTxtBox.BackColor = Color.Red;
                    MessageBox.Show("Email is not valid", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    emailTxtBox.Focus();
                    return;
                }
            }**/

            if (addressTxtBox.Text == "")
            {
                //addressTxtBox.BackColor = Color.Red;
                MessageBox.Show("Please enter your address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fNameTxtBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(courseCB.Text))
            {
                //courseCB.BackColor = Color.Red;
                MessageBox.Show("Please enter course details!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fNameTxtBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(genderCBox.Text))
            {
                //genderCBox.BackColor = Color.Red;
                MessageBox.Show("Please select any gender!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fNameTxtBox.Focus();
                return;
            }
            if (DateTime.Today.AddYears(-17) < birthDateDP.Value.Date)
            {
                MessageBox.Show("Must be more than 17 years to enroll!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                birthDateDP.Focus();
                return;
            }

            //Inserting records..
            StudentInfo obj = new StudentInfo();
            string firstName = fNameTxtBox.Text;
            string lastName = lNameTxtBox.Text;
            obj.Name = firstName + " " + lastName;
            obj.ContactNo = contacTxtBox.Text;
            obj.Email = emailTxtBox.Text;
            obj.Address = addressTxtBox.Text;
            obj.EnrolledCourse = courseCB.SelectedItem.ToString();
            obj.Gender = genderCBox.SelectedItem.ToString();
            obj.RegistrationDate = registerDP.Value;
            obj.BirthDate = birthDateDP.Value;
            obj.Add(obj);
            BindGrid();
            Clear();
            MessageBox.Show("Successfully added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BindGrid()
        {
            StudentInfo obj = new StudentInfo();
            List<StudentInfo> studentLists = obj.List();
            DataTable dt = Utility.ConvertToDataTable(studentLists);
            dataGridStudent.DataSource = dt;
            BindChart(studentLists);
        }
        private void Clear()
        {
            fNameTxtBox.Text = "";
            lNameTxtBox.Text = "";
            contacTxtBox.Text = "";
            emailTxtBox.Text = "";
            addressTxtBox.Text = "";
            courseCB.SelectedItem = null;
            genderCBox.SelectedItem = null;
            registerDP.Value = DateTime.Today;
            birthDateDP.Value = DateTime.Today;
        }

        private void dataGridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentInfo obj = new StudentInfo();
            if (e.ColumnIndex == 0)
            {
                string value = dataGridStudent[2, e.RowIndex].Value.ToString();
                int id = 0;
                if (String.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Please select the row having values.");
                }
                else
                {
                    id = int.Parse(value);
                    StudentInfo s = obj.List().Where(x => x.Id == id).FirstOrDefault();
                    IdTxtBox.Text = s.Id.ToString();
                    fNameTxtBox.Text = s.Name.Split(' ')[0];
                    lNameTxtBox.Text = s.Name.Split(' ')[1];
                    contacTxtBox.Text = s.ContactNo;
                    emailTxtBox.Text = s.Email;
                    addressTxtBox.Text = s.Address;
                    //courseCB.SelectedItem = s.EnrolledCourse;
                    courseCB.SelectedItem = s.EnrolledCourse;
                    genderCBox.SelectedItem = s.Gender;
                    registerDP.Value = s.RegistrationDate;
                    birthDateDP.Value = s.BirthDate;
                    addBtn.Visible = false;
                    updateBtn.Visible = true;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                string msg = "Do you want to delete this record?"; //Message for the box.
                string title = "Are you sure?"; //title of the box.
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel; //Generating 'Ok and Cancel buttons' in dialog box.
                DialogResult result = MessageBox.Show(msg, title, buttons); //Creating dialog box

                if (result == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    string value = dataGridStudent[2, e.RowIndex].Value.ToString();
                    obj.Delete(int.Parse(value));
                    BindGrid();
                    MessageBox.Show("This row has been sucessfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //validating same email...
            /**for (int row = 0; row < dataGridStudent.Rows.Count; row++)
            {
                for (int col = 0; col < dataGridStudent.Columns.Count; col++)
                {
                    if (dataGridStudent.Rows[row].Cells[col].Value != null
                        && dataGridStudent.Rows[row].Cells[col].Value.Equals(emailTxtBox.Text.Trim()))
                    {
                        MessageBox.Show("Duplicate Values");
                    }
                }
            }**/
            //Validating Text fields.
            if (fNameTxtBox.Text == ""
                || fNameTxtBox.Text.Any(i => char.IsNumber(i))
                || string.IsNullOrWhiteSpace(fNameTxtBox.Text)
                && fNameTxtBox.Text.Length > 0)
            {
                //fNameTxtBox.BackColor = Color.Red;
                MessageBox.Show("Fill the First name correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //fNameTxtBox.Focus();
                return;
            }
            if (lNameTxtBox.Text == ""
                || lNameTxtBox.Text.Any(i => char.IsNumber(i))
                || string.IsNullOrWhiteSpace(lNameTxtBox.Text)
                && lNameTxtBox.Text.Length > 0)
            {
                //lNameTxtBox.BackColor = Color.Red;
                MessageBox.Show("Fill the Last name correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lNameTxtBox.Focus();
                return;
            }
            if (contacTxtBox.Text == ""
                || contacTxtBox.Text.Any(i => char.IsLetter(i))
                || string.IsNullOrWhiteSpace(contacTxtBox.Text)
                && contacTxtBox.Text.Length > 0)
            {
                //fNameTxtBox.BackColor = Color.Red;
                MessageBox.Show("Fill the contact number correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fNameTxtBox.Focus();
                //return;
            }

            if (emailTxtBox.Text == "")
            {
                MessageBox.Show("Fill the email correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emailTxtBox.Focus();
                return;
            }

            if (emailTxtBox.Text.Length > 0)
            {
                Regex RegxEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                if (!RegxEmail.IsMatch(emailTxtBox.Text.Trim()))
                {
                    //emailTxtBox.BackColor = Color.Red;
                    MessageBox.Show("Email is not valid", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    emailTxtBox.Focus();
                    return;
                }
            }

            if (addressTxtBox.Text == "")
            {
                //addressTxtBox.BackColor = Color.Red;
                MessageBox.Show("Please enter your address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //fNameTxtBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(courseCB.Text))
            {
                //courseCB.BackColor = Color.Red;
                MessageBox.Show("Please enter course details!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //fNameTxtBox.Focus();
                return;
            }
            if (string.IsNullOrEmpty(genderCBox.Text))
            {
                //genderCBox.BackColor = Color.Red;
                MessageBox.Show("Please select any gender!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //fNameTxtBox.Focus();
                return;
            }
            if (DateTime.Today.AddYears(-17) < birthDateDP.Value.Date)
            {
                MessageBox.Show("Must be more than 17 years to enroll!", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                birthDateDP.Focus();
                return;
            }

            //inserting values
            
            StudentInfo obj = new StudentInfo();
            obj.Id = int.Parse(IdTxtBox.Text);
            string firstName = fNameTxtBox.Text;
            string lastName = lNameTxtBox.Text;
            obj.Name = firstName + " " + lastName;
            obj.ContactNo = contacTxtBox.Text;
            obj.Email = emailTxtBox.Text;
            obj.Address = addressTxtBox.Text;
            obj.EnrolledCourse = courseCB.SelectedItem.ToString();
            obj.Gender = genderCBox.SelectedItem.ToString();
            obj.RegistrationDate = registerDP.Value;
            obj.BirthDate = birthDateDP.Value;
            obj.Edit(obj);
            BindGrid();
            Clear();
            IdTxtBox.Text = "";
            updateBtn.Visible = false;
            addBtn.Visible = true;
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if ((fNameTxtBox.Text != "" )
                || (lNameTxtBox.Text != "")
                || (contacTxtBox.Text != "")
                || (emailTxtBox.Text != "")
                || (addressTxtBox.Text != "")
                || (courseCB.SelectedItem != null)
                || (genderCBox.SelectedItem != null))
            {
                string msgCancel = "Do you want to clear all the fields?"; //Message for the box.
                string title = "Are you sure?"; //title of the box.
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel; //Generating 'Ok and Cancel buttons' in dialog box.
                DialogResult result = MessageBox.Show(msgCancel, title, buttons);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    Clear();
                    IdTxtBox.Text = "";
                    addBtn.Visible = true;
                    updateBtn.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please fill any of the text fields, to clear!", "Empty fields",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BindChart(List<StudentInfo> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.EnrolledCourse)
                    .Select(cl => new
                    {
                        Course = cl.First().EnrolledCourse,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                chart.DataSource = dt;
                chart.Name = "Courses";
                chart.Series["Series1"].XValueMember = "Course";
                chart.Series["Series1"].YValueMembers = "Count";
                this.chart.Titles.Remove(this.chart.Titles.FirstOrDefault());
                chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                this.chart.Titles.Add("Weekly Enrollment Chart");
                chart.Series["Series1"].IsValueShownAsLabel = true;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void importBtn_Click(object sender, EventArgs e)
        {

        }

        private void sortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (sortOrderCB.SelectedItem == null)
            {
                sortOrderCB.BackColor = Color.Red;
                MessageBox.Show("Please select the order", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //sortOrderCB.Focus();
            }
            else if (sortCB.SelectedItem == null)
            {
                sortCB.BackColor = Color.Red;
                MessageBox.Show("Please select what to sort!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //sortCB.Focus();
            }
            else
            {
                string sortBy = sortCB.SelectedItem.ToString();
                string orderBy;
                if (sortOrderCB.SelectedItem.ToString().Equals("Ascending"))
                {
                    orderBy = "Ascending";
                }
                else
                {
                    orderBy = "Descending";
                }
                SortList(sortBy, orderBy);

            }
        }
        public void SortList(string sortBy, string orderBy)
        {
            StudentInfo student = new StudentInfo();
            List<StudentInfo> studentList = new List<StudentInfo>();
            studentList = student.List();

            for (int i = 1; i < studentList.Count; i++)
            {
                for (int j =  0; j < studentList.Count-i; j++)
                {
                    if (sortBy == "Name")
                    {
                        int compared = String.Compare(studentList[j].Name, studentList[j+1].Name);
                        if (orderBy == "Ascending")
                        {
                            if (compared == 1)
                            {
                                ItemSwap(j, j + 1, studentList);
                            }
                        }
                        if (orderBy == "Descending")
                        {
                            if (compared == -1)
                            {
                                ItemSwap(j + 1, j, studentList);
                            }
                        }
                    }
                    if (sortBy == "Registration Date")
                    {
                        int compared = DateTime.Compare(Convert.ToDateTime(studentList[j].RegistrationDate), Convert.ToDateTime(studentList[j + 1].RegistrationDate));
                        if (orderBy == "Ascending")
                        {
                            if (compared == 1)
                            {
                                ItemSwap(j, j + 1, studentList);
                            }
                        }
                        if (orderBy == "Descending")
                        {
                            if (compared == -1)
                            {
                                ItemSwap(j +1 , j, studentList);
                            }
                        }
                    }
                }
            }
            DataTable dataTable = Utility.ConvertToDataTable(studentList);
            dataGridStudent.DataSource = dataTable;
        }
        private void ItemSwap (int i, int j, List<StudentInfo> studentList)
        {
            var temp = studentList[i];
            studentList[i] = studentList[j];
            studentList[j] = temp;
        }

        private void weeklyReportDP_ValueChanged(object sender, EventArgs e)
        {
            DateTime pickedDate = weeklyReportDP.Value;
            var diff = pickedDate.DayOfWeek - CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
            {
                diff += 7;
            }
            var firstDayOfWeek = pickedDate.AddDays(-diff).Date;
            var lastDayOfWeek = firstDayOfWeek.AddDays(7);
            weeklyReportOfStudent.Rows.Clear();
            StudentInfo obj = new StudentInfo();
            List<StudentInfo> studentLists = obj.List();
            var convertStudents = studentLists.Where(s => s.RegistrationDate >= firstDayOfWeek && s.RegistrationDate < lastDayOfWeek);

            int computing = 0;
            int networking = 0;
            int multimedia = 0;

            foreach (StudentInfo std in convertStudents)
            {
                if (std.EnrolledCourse == "Computing")
                {
                    computing += 1;
                }
                if (std.EnrolledCourse == "Networking")
                {
                    networking += 1;
                }
                if (std.EnrolledCourse == "Multimedia")
                {
                    multimedia += 1;
                }
            }

            weeklyReportOfStudent.Rows.Add(new Object[] { "Computing", computing });
            weeklyReportOfStudent.Rows.Add(new Object[] { "Multimedia", multimedia });
            weeklyReportOfStudent.Rows.Add(new Object[] { "Networking", networking });

            if (computing == 0 && networking == 0 && multimedia == 0)
            {
                //nothing to do here.
            }

        }
       
    }
}
