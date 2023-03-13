using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestInduction
{
    public partial class Form1 : Form
    {


        public environment ambiente;
        public BindingSource source;
        public List<dataRow> Datos;
        public Form1()
        {
            InitializeComponent();
            source = new BindingSource();
            Datos = new List<dataRow>();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                particle particula = new particle(Convert.ToDouble(textBox2.Text), new Vector3D(0, 0, 0));
                ambiente = new environment(new Vector3D(9.81, 0, 0), new Vector3D(Convert.ToDouble(textBox3.Text), 0, 0), Convert.ToDouble(textBox6.Text), 0);
                double mFieldX = Convert.ToDouble(textBox3.Text);
                if (mFieldX == 0)
                {
                    label6.Text = "Magnetic field needs to be different from 0";
                }
                else
                {
                    ambiente.t = 0;

                    for (int i = 0; i < 10; i++)
                    {
                        Datos.Add(
                        new dataRow(particula.getVelocity(ambiente, Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox1.Text)).x, ambiente.t, particula.getAcceleration(ambiente, Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox1.Text)).x, particula.getPosition(ambiente, Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox1.Text)).x));
                        ambiente.t = (i + 1) * 0.2;
                    }
                    source.DataSource = Datos;
                    source.ResetBindings(false);
                    dataGridView1.DataSource = source;
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.Width = 60;
                    }
                    chart1.Series[0] = new Series("Vx");
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.ChartAreas[0].AxisX.Title = dataGridView1.Columns[1].DataPropertyName + " (s)";
                    chart1.ChartAreas[0].AxisY.Title = dataGridView1.Columns[0].DataPropertyName + " (m/s)";
                    chart1.Series[0].XValueMember = dataGridView1.Columns[1].DataPropertyName;
                    chart1.Series[0].YValueMembers = dataGridView1.Columns[0].DataPropertyName;
                    chart1.DataSource = dataGridView1.DataSource;
                }
            }
            catch(Exception error)
            {
                label6.Text = error.Message + " Please fill in the blank spaces";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                particle particula = new particle(Convert.ToDouble(textBox2.Text), new Vector3D(0, 0, 0));
                ambiente = new environment(new Vector3D(9.81, 0, 0), new Vector3D(Convert.ToDouble(textBox3.Text), 0, 0), Convert.ToDouble(textBox6.Text), 0);
                double mFieldX = Convert.ToDouble(textBox3.Text);

                ambiente.t = 0;

                for (int i = 0; i < 10; i++)
                {
                    Datos.Add(
                    new dataRow(particula.getVelocity(ambiente, Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox1.Text)).x, ambiente.t, particula.getAcceleration(ambiente, Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox1.Text)).x, particula.getPosition(ambiente, Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox1.Text)).x));
                    ambiente.t = (i + 1) * 0.2;
                }
                source.DataSource = Datos;
                source.ResetBindings(false);
                dataGridView1.DataSource = source;
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Width = 60;
                }
                chart1.Series[0] = new Series("Ax");
                chart1.Series[0].ChartType = SeriesChartType.Line;
                chart1.ChartAreas[0].AxisX.Title = dataGridView1.Columns[1].DataPropertyName + " (s)";
                chart1.ChartAreas[0].AxisY.Title = dataGridView1.Columns[2].DataPropertyName + " (m/s^2)";
                chart1.Series[0].XValueMember = dataGridView1.Columns[1].DataPropertyName;
                chart1.Series[0].YValueMembers = dataGridView1.Columns[2].DataPropertyName;
                chart1.DataSource = dataGridView1.DataSource;
            }
            catch (Exception error)
            {
                label6.Text = error.Message + " Please fill in the blank spaces";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                particle particula = new particle(Convert.ToDouble(textBox2.Text), new Vector3D(0, 0, 0));
                ambiente = new environment(new Vector3D(9.81, 0, 0), new Vector3D(Convert.ToDouble(textBox3.Text), 0, 0), Convert.ToDouble(textBox6.Text), 0);
                double mFieldX = Convert.ToDouble(textBox3.Text);

                ambiente.t = 0;

                for (int i = 0; i < 10; i++)
                {
                    Datos.Add(
                    new dataRow(particula.getVelocity(ambiente, Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox1.Text)).x, ambiente.t, particula.getAcceleration(ambiente, Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox1.Text)).x, particula.getPosition(ambiente, Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox1.Text)).x));
                    ambiente.t = (i + 1) * 0.2;
                }
                source.DataSource = Datos;
                source.ResetBindings(false);
                dataGridView1.DataSource = source;
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Width = 60;
                }
                chart1.Series[0] = new Series("Px");
                chart1.Series[0].ChartType = SeriesChartType.Line;
                chart1.ChartAreas[0].AxisX.Title = dataGridView1.Columns[1].DataPropertyName + " (s)";
                chart1.ChartAreas[0].AxisY.Title = dataGridView1.Columns[3].DataPropertyName + " (m)";
                chart1.Series[0].XValueMember = dataGridView1.Columns[1].DataPropertyName;
                chart1.Series[0].YValueMembers = dataGridView1.Columns[3].DataPropertyName;
                chart1.DataSource = dataGridView1.DataSource;
            }
            catch (Exception error)
            {
                label6.Text = error.Message + " Please fill in the blank spaces";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            dataGridView1.Columns.Clear();
            source = new BindingSource();
            Datos = new List<dataRow>();
        }
    }
    public class particle
    {
        public double mass { get; set; }
        public Vector3D position { get; set; }
        public particle()
        {
            mass = 1; position = new Vector3D();
        }
        public particle(double Mass, Vector3D Position)
        {
            mass = Mass; position = Position;
        }
        public Vector3D getVelocity(environment env, double length, double massB) => new Vector3D((env.gField.x * massB * env.resistance * (1 - Math.Pow(Math.E, ((- env.mField.x * env.mField.x * length * length * env.t) / (env.resistance * (mass + massB)))))) / (env.mField.x * env.mField.x * length * length), (env.gField.y * massB * env.resistance * (1 - Math.Pow(Math.E, ((-env.mField.y * env.mField.y * length * length * env.t) / (env.resistance * (mass + massB)))))) / (env.mField.y * env.mField.y * length * length), (env.gField.z * massB * env.resistance * (1 - Math.Pow(Math.E, ((-env.mField.z * env.mField.z * length * length * env.t) / (env.resistance * (mass + massB)))))) / (env.mField.z * env.mField.z * length * length));
        public Vector3D getAcceleration(environment env, double length, double massB) => new Vector3D((env.gField.x * massB * (Math.Pow(Math.E, ((-env.mField.x * env.mField.x * length * length * env.t) / (env.resistance * (mass + massB)))))) / (mass + massB), (env.gField.y * massB * (Math.Pow(Math.E, ((-env.mField.y * env.mField.y * length * length * env.t) / (env.resistance * (mass + massB)))))) / (mass + massB), (env.gField.z * massB * (Math.Pow(Math.E, ((-env.mField.x* env.mField.z * length * length * env.t) / (env.resistance * (mass + massB)))))) / (mass + massB));
        public Vector3D getPosition(environment env, double length, double massB) => new Vector3D((env.gField.x * massB * env.resistance * ((env.resistance * (mass + massB)) * (Math.Pow(Math.E, ((-env.mField.x * env.mField.x * length * length * env.t) / (env.resistance * (mass + massB)))) - 1) + env.mField.x * env.mField.x * length * length * env.t)) / (Math.Pow(env.mField.x, 4) * Math.Pow(length, 4)), (env.gField.y * massB * env.resistance * ((env.resistance * (mass + massB)) * (Math.Pow(Math.E, ((-env.mField.y * env.mField.y * length * length * env.t) / (env.resistance * (mass + massB)))) - 1) + env.mField.y * env.mField.y * length * length * env.t)) / (Math.Pow(env.mField.y, 4) * Math.Pow(length, 4)), (env.gField.z * massB * env.resistance * ((env.resistance * (mass + massB)) * (Math.Pow(Math.E, ((-env.mField.z * env.mField.z * length * length * env.t) / (env.resistance * (mass + massB)))) - 1) + env.mField.z * env.mField.z * length * length * env.t)) / (Math.Pow(env.mField.z, 4) * Math.Pow(length, 4)));
}
    public class environment
    {
        //propiedades
        public Vector3D gField { get; set; }
        public Vector3D mField { get; set; }
        public double resistance { get; set; }
        public double t { get; set; }
            //funciones
            public environment()
        {
            gField = new Vector3D(); mField = new Vector3D(); resistance = 1; t = 1;
        }
        public environment(Vector3D GField, Vector3D MField, double Resistance, double T)
        {
            gField = GField; mField = MField; resistance = Resistance; t = T; 
        }
    }
    public class Vector3D
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public Vector3D() { x = 0; y = 0; z = 0; }
        public Vector3D(double X, double Y, double Z)
        {
            x = X; y = Y; z = Z;
        }
    }
    public class dataRow
    {
        public double Vx { get; set; }
        public double t { get; set; }
        public double Ax { get; set; }
        public double Px { get; set; }
        public dataRow() { Vx = 0; t = 0; Ax = 0; Px = 0; }
        public dataRow(double VX, double T, double AX, double PX)
        { Vx = VX; t = T; Ax = AX; Px = PX; }
    }


}




