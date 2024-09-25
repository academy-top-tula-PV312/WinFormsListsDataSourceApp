namespace WinFormsListsDataSourceApp
{
    public partial class Form1 : Form
    {
        List<Employee>? employees;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employees = new List<Employee>()
            {
                new(){ Name = "Bobby", Age = 32, Salary = 100000 },
                new(){ Name = "Tommy", Age = 19, Salary = 120000 },
                new(){ Name = "Jimmy", Age = 28, Salary = 110000 },
                new(){ Name = "Denny", Age = 21, Salary = 150000 },
                new(){ Name = "Poppy", Age = 36, Salary = 170000 },
            };

            //listEmployees.Items.AddRange(employees.ToArray());

            listEmployees.DataSource = employees;
            listEmployees.DisplayMember = "Name";
            listEmployees.ValueMember = "Id";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (listEmployees.SelectedItems.Count > 0)
            //{
            //    listEmployees.Items.RemoveAt(listEmployees.SelectedIndex);
            //    var empl = employees.FirstOrDefault(e => e == listEmployees.SelectedItem);
            //    if(empl is not null)
            //        employees.Remove(empl);
            //    listEmployees.Refresh();
            //}
        }

        private void viewList_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (var employee in employees)
                msg += employee + "\n";
            MessageBox.Show(msg);
        }

        private void listEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"{listEmployees.SelectedValue}");
        }
    }
}
