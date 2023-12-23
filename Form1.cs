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
            //初始化label颜色
            label_distance.BackColor = Color.Transparent;
            label_speed.BackColor = Color.Transparent;
            label_time.BackColor = Color.Transparent;

            //判断每个格子里是否有数据
            if(TB_distance.Text != "" && TB_speed.Text != "" && TB_time.Text == "")//路程有，速度有，时间无
            {
                double distance = System.Convert.ToDouble(TB_distance.Text);
                double speed = System.Convert.ToDouble(TB_speed.Text);
                
                double time = distance / speed;//求时间
                TB_time.Text = time.ToString();//输出到文本框
                MessageBox.Show("计算成功");
                label_time.BackColor = Color.Red;//改label颜色
                
            }
            else if(TB_distance.Text != "" && TB_speed.Text == "" && TB_time.Text != "")//路程有，速度无，时间有
            {
                double distance = System.Convert.ToDouble(TB_distance.Text);
                double time = System.Convert.ToDouble(TB_time.Text);

                double speed = distance / time;//求速度
                TB_speed.Text = speed.ToString();//输出到文本框
                MessageBox.Show("计算成功");
                label_speed.BackColor = Color.Red;//改label颜色
                
            }
            else if(TB_distance.Text == "" && TB_speed.Text != "" && TB_time.Text != "")//路程无，速度有，时间有
            {
                double speed = System.Convert.ToDouble(TB_speed.Text);
                double time = System.Convert.ToDouble(TB_time.Text);

                double distance = speed * time;//求路程
                TB_distance.Text = distance.ToString();//输出到文本框
                MessageBox.Show("计算成功");
                label_distance.BackColor = Color.Red;//改label颜色
                
            }
            else if(TB_distance.Text != "" && TB_speed.Text != "" && TB_time.Text != "")
            {
                //转换
                double speed = System.Convert.ToDouble(TB_speed.Text);
                double time = System.Convert.ToDouble(TB_time.Text);
                double originalDistance = System.Convert.ToDouble(TB_distance.Text);

                double targetDistance = speed * time;//求目标路程
                
                if(originalDistance == targetDistance)
                {
                    MessageBox.Show("数据正确");
                }
                else
                {
                    MessageBox.Show("数据错误");
                }

            }
            else
            {
                MessageBox.Show("计算失败");
            }
        }
    }
}
