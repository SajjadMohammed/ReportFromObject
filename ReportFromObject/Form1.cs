using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ReportFromObject
{
    public partial class Form1 : Form
    {

        private List<StudentsInfo> std = new List<StudentsInfo>();
        private int id = 1;

        public Form1()
        {
            InitializeComponent();

            idText.Text = id.ToString();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //std.Sort((x, y) => (x.S_FName.CompareTo(y.S_FName)));
            //or 
            std.OrderBy(name => name.FullName);

            ReportForm repf = new ReportForm();
            repf.StudentsInfoBindingSource.DataSource = std;
            repf.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            repf.reportViewer1.ShowToolBar = false;
            repf.reportViewer1.RefreshReport();
            repf.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            std.Add(new StudentsInfo
            {
                ID = id,
                FullName = nameText.Text,
                Address = addressText.Text,
                BirthDate = DateTime.Parse(dobText.Text)
            });

            idText.Text = (++id).ToString();

            nameText.Text = dobText.Text = addressText.Text = "";
        }
    }
}