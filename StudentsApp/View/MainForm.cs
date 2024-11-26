using Newtonsoft.Json;
using StudentsApp.Model.Classes;
using System.ComponentModel;
using StudentsApp.Model.Enums;
using StudentsApp.View;

namespace StudentsApp
{
    public partial class MainForm : Form
    {
       
        /// <summary>
        /// ������ ��������� ������ Student.
        /// </summary>
        private BindingList<Student> _students = new BindingList<Student>();

        /// <summary>
        /// ������������� ���� � �����, ��� ������ ������ ���� json.
        /// </summary>
        private string _pathToJson =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StudentsApp";

        /// <summary>
        /// ������������� ���� � ����� json.
        /// </summary>
        private string _jsonPath =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\StudentsApp\\students.json";

        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(_pathToJson))
            {
                Directory.CreateDirectory(_pathToJson);
            }
            if (!File.Exists(_jsonPath))
            {
                FileStream fileStream = new FileStream(_jsonPath, FileMode.CreateNew);
                fileStream.Close();
            }
            JsonTextReader reader = new JsonTextReader(new StreamReader(_jsonPath));
            reader.SupportMultipleContent = true;
            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }
                JsonSerializer serializer = new JsonSerializer();
                Student tempStudent = serializer.Deserialize<Student>(reader);
                _students.Add(tempStudent);
            }
            reader.Close();
            StudentsListBox.DataSource = _students;
            StudentsListBox.DisplayMember = nameof(Student.Info);
            RecordNumberTextBox.ReadOnly = true;
        }


        /// <summary>
        /// ��������� ���������� ������ Student �� �������� �� ������� �����.
        /// </summary>
        private void StudentsSort()
        {
            int size = _students.Count;
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < (size - i); j++)
                {
                    if (String.Compare(_students.ElementAt(j).FullName, _students.ElementAt(j + 1).FullName) > 0)
                    {
                        Student temp = _students.ElementAt(j);
                        _students[j] = _students.ElementAt(j + 1);
                        _students[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// ��������� ��������� ���� ���������� ��������.
        /// </summary>
        /// <param name="student">�������, ��������� ���� �������� ���������� ��������.</param>
        private void UpdateStudentsInfo(Student student)
        {
            FullNameTextBox.Text = student.FullName;
            RecordNumberTextBox.Text = student.RecordNumber.ToString();
            GroupTextBox.Text = student.Group;
            FacultyComboBox.Text = student.Faculty;
            FormOfEducationComboBox.Text = student.FormOfEducation;
        }

        /// <summary>
        /// ������� ��� ��������� ���� � ������������� �� � �������� ����.
        /// </summary>
        private void ClearStudentsInfo()
        {
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            RecordNumberTextBox.Clear();
            GroupTextBox.Clear();
            GroupTextBox.BackColor = Color.White;
            FacultyComboBox.Text = "";
            FormOfEducationComboBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ��� ��������� ���������� �������� StudentsListBox
        /// ��������� ��� ��������� ���� ���������� ���������� _student.
        /// ���� ������� �� ������, �� ������� ��� ��������� ����.
        /// </summary>
        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex != -1)
            {
                UpdateStudentsInfo(_students[StudentsListBox.SelectedIndex]);
            }
            else
            {
                ClearStudentsInfo();
            }
        }

        /// <summary>
        /// ��� ������� �� ������ ���������� �������� ��������� ��������������� �����
        /// � ��������� ���������� �������� � ������ _students.
        /// ��������� ������ ��������� � ���������� ������ �������� � ���� json.
        /// </summary>
        private void StudentsAddPictureBox_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(new Student());
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                _students.Add(editForm.CurrentStudent);
            }
            StudentsListBox.SelectedIndex = -1;
            StudentsSort();
            File.WriteAllText(_jsonPath, string.Empty);
            for (int i = 0; i < _students.Count; i++)
            {
                File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_students[i]));
            }
        }

        /// <summary>
        /// ��� ������� �� ������ �������� �������� ������� ���������� �������� �� ������ � �� StudentsListBox.
        /// ����� ������� ���������� �������� �� ����� json.
        /// </summary>
        private void StudentsEditPictureBox_Click(object sender, EventArgs e)
        {
            var selectedIndex = StudentsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _students.RemoveAt(selectedIndex);
                StudentsListBox.SelectedIndex = -1;
                File.WriteAllText(_jsonPath, string.Empty);
                for (int i = 0; i < _students.Count; i++)
                {
                    File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_students[i]));
                }
            }
        }

        /// <summary>
        /// ��� ������� �� ������ ��������� �������� ��������� ��������������� �����
        /// � �������� �������� � ������ _students.
        /// ��������� ������ ��������� � ���������� ����������� �������� � ���� json.
        /// </summary>
        private void StudentsDeletePictureBox_Click(object sender, EventArgs e)
        {
            var selectedIndex = StudentsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                EditForm editForm = new EditForm(_students[selectedIndex]);
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK)
                {
                    _students[selectedIndex] = editForm.CurrentStudent;
                }
            }
            StudentsListBox.SelectedIndex = -1;
            StudentsSort();
            File.WriteAllText(_jsonPath, string.Empty);
            for (int i = 0; i < _students.Count; i++)
            {
                File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_students[i]));
            }
        }
    }
}
