using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Ketnoidb dB = new Ketnoidb();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Them_Click(object sender, EventArgs e)
        {
            double tb = (double.Parse(txttoan.Text) + double.Parse(txtvan.Text) + double.Parse(txtanh.Text)) / 3;
            dB.updatedata("insert into diemthi (masv,hoten,diemtoan,diemvan,diemanh,diemtrungbinh) values ('" + txtmasv.Text + "','" + txthoten.Text + "','" +  txttoan.Text + "','" + txtvan.Text + "','" + txtanh.Text + "','"+tb+"')");
            DataTable listdiem = dB.Dsdiem("select id as 'id', masv as'Ma SV', hoten as  'Ho ten', diemtoan as'Diem toan',diemvan as'Diem van',diemanh as 'Diem anh',diemtrungbinh as'Diem trung binh' from Diemthi");
            dataGridView1.DataSource = listdiem;
            dataGridView1.Columns[0].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable listdiem = dB.Dsdiem ("select id as 'id', masv as'Ma SV', hoten as  'Ho ten', diemtoan as'Diem toan',diemvan as'Diem van',diemanh as 'Diem anh',diemtrungbinh as'Diem trung binh' from Diemthi");
            dataGridView1.DataSource = listdiem;
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasv.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txthoten.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttoan.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtvan.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtanh.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            double tb = (double.Parse(txttoan.Text)+double.Parse(txtvan.Text)+double.Parse(txtanh.Text))/3;
            dB.updatedata("update diemthi set masv='"+txtmasv.Text+"',hoten='"+txthoten.Text+"',diemtoan='"+txttoan.Text+"',diemvan='"+txtvan.Text+"',diemanh='"+txtanh.Text+"',diemtrungbinh='"+tb+"'where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'");
            DataTable listdiem = dB.Dsdiem("select id as 'id', masv as'Ma SV', hoten as  'Ho ten', diemtoan as'Diem toan',diemvan as'Diem van',diemanh as 'Diem anh',diemtrungbinh as'Diem trung binh' from Diemthi");
            dataGridView1.DataSource = listdiem;
            dataGridView1.Columns[0].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dB.updatedata("delete from diemthi where id='" +dataGridView1.CurrentRow.Cells[0].Value.ToString()+"'");
            DataTable listdiem = dB.Dsdiem("select id as 'id', masv as'Ma SV', hoten as  'Ho ten', diemtoan as'Diem toan',diemvan as'Diem van',diemanh as 'Diem anh',diemtrungbinh as'Diem trung binh' from Diemthi");
            dataGridView1.DataSource = listdiem;
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
