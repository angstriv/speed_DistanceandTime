namespace speed_DistanceandTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            //��ʼ��label��ɫ
            label_distance.BackColor = Color.Transparent;
            label_speed.BackColor = Color.Transparent;
            label_time.BackColor = Color.Transparent;

            //�ж�ÿ���������Ƿ�������
            if(TB_distance.Text != "" && TB_speed.Text != "" && TB_time.Text == "")//·���У��ٶ��У�ʱ����
            {
                double distance = System.Convert.ToDouble(TB_distance.Text);
                double speed = System.Convert.ToDouble(TB_speed.Text);
                
                double time = distance / speed;//��ʱ��
                TB_time.Text = time.ToString();//������ı���
                MessageBox.Show("����ɹ�");
                label_time.BackColor = Color.Red;//��label��ɫ
                
            }
            else if(TB_distance.Text != "" && TB_speed.Text == "" && TB_time.Text != "")//·���У��ٶ��ޣ�ʱ����
            {
                double distance = System.Convert.ToDouble(TB_distance.Text);
                double time = System.Convert.ToDouble(TB_time.Text);

                double speed = distance / time;//���ٶ�
                TB_speed.Text = speed.ToString();//������ı���
                MessageBox.Show("����ɹ�");
                label_speed.BackColor = Color.Red;//��label��ɫ
                
            }
            else if(TB_distance.Text == "" && TB_speed.Text != "" && TB_time.Text != "")//·���ޣ��ٶ��У�ʱ����
            {
                double speed = System.Convert.ToDouble(TB_speed.Text);
                double time = System.Convert.ToDouble(TB_time.Text);

                double distance = speed * time;//��·��
                TB_distance.Text = distance.ToString();//������ı���
                MessageBox.Show("����ɹ�");
                label_distance.BackColor = Color.Red;//��label��ɫ
                
            }
            else if(TB_distance.Text != "" && TB_speed.Text != "" && TB_time.Text != "")
            {
                //ת��
                double speed = System.Convert.ToDouble(TB_speed.Text);
                double time = System.Convert.ToDouble(TB_time.Text);
                double originalDistance = System.Convert.ToDouble(TB_distance.Text);

                double targetDistance = speed * time;//��Ŀ��·��
                
                if(originalDistance == targetDistance)
                {
                    MessageBox.Show("������ȷ");
                }
                else
                {
                    MessageBox.Show("���ݴ���");
                }

            }
            else
            {
                MessageBox.Show("����ʧ��");
            }
        }
    }
}
