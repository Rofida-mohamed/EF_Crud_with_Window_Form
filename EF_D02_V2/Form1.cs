using EF_D02_V2.Models;

namespace EF_D02_V2
{
    public partial class Form1 : Form
    {
        companyContext context = new companyContext();
        int selected;
        public Form1()
        {
            InitializeComponent();
            selected = 0;
            editbtn.Enabled = false;
            delbtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            deptBox.Items.Clear();
            var students = context.students.Select(s => new { Name = s.Name, Age = s.age, Department = s.dept.name }).ToList();

            dataGridView1.DataSource = students;

            var department = context.departments.Select(d => d.name).ToList();

            foreach (var dept in department)
            {
                deptBox.Items.Add(dept);
            }
        }

        private void Clear_var()
        {
            nameTextBox.Text = ageTextBox.Text = "";
            deptBox.SelectedItem = null;
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            student std = new student();

            std.Name = nameTextBox.Text;
            std.age = int.Parse(ageTextBox.Text);

            var deptID = context.departments.Where(d => d.name == deptBox.SelectedItem).Select(d => d.Id).FirstOrDefault();

            std.D_Id = deptID;

            context.students.Add(std);
            context.SaveChanges();
            load();
            Clear_var();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                var name = selectedRow.Cells["Name"].Value.ToString();
                var age = selectedRow.Cells["Age"].Value.ToString();

                nameTextBox.Text = name;
                ageTextBox.Text = age;


                var selectedDept = selectedRow.Cells["Department"].Value.ToString();


                int deptIndex = deptBox.FindStringExact(selectedDept);


                if (deptIndex != -1)
                {
                    deptBox.SelectedIndex = deptIndex;


                }

                var departID = context.departments.Where(dept => dept.name == selectedDept).Select(d => d.Id).SingleOrDefault();

                var stdId = context.students.Where(s => s.Name.ToLower() == name.ToLower() && s.age == int.Parse(age) && s.D_Id == departID).Select(std => std.Id).FirstOrDefault();

                selected = stdId;
                editbtn.Enabled = true;
                delbtn.Enabled = true;
                addbtn.Enabled = false;

            }
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            student std = new student();

            std.Id = selected;

            context.students.Attach(std);
            context.students.Remove(std);
            context.SaveChanges();

            Clear_var();
            load();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            student std = new student();

            std.Name = nameTextBox.Text;
            std.age = int.Parse(ageTextBox.Text);

            var deptID = context.departments.Where(d => d.name == deptBox.SelectedItem).Select(d => d.Id).FirstOrDefault();

            std.D_Id = deptID;
            std.Id = selected;

            context.students.Update(std);
            context.SaveChanges();
            load();
            Clear_var();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Clear_var();
            dataGridView1.ClearSelection();
            editbtn.Enabled = false;
            delbtn.Enabled=false;
            addbtn.Enabled = true;
        }
    }
}
