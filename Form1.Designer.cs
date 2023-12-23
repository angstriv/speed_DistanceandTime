namespace speed_DistanceandTime
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TB_distance = new TextBox();
            TB_speed = new TextBox();
            TB_time = new TextBox();
            execute = new Button();
            label_distance = new Label();
            label_speed = new Label();
            label_time = new Label();
            SuspendLayout();
            // 
            // TB_distance
            // 
            TB_distance.Location = new Point(284, 317);
            TB_distance.Name = "TB_distance";
            TB_distance.Size = new Size(300, 53);
            TB_distance.TabIndex = 0;
            // 
            // TB_speed
            // 
            TB_speed.Location = new Point(896, 317);
            TB_speed.Name = "TB_speed";
            TB_speed.Size = new Size(300, 53);
            TB_speed.TabIndex = 1;
            // 
            // TB_time
            // 
            TB_time.Location = new Point(1356, 317);
            TB_time.Name = "TB_time";
            TB_time.Size = new Size(300, 53);
            TB_time.TabIndex = 2;
            // 
            // execute
            // 
            execute.Location = new Point(927, 655);
            execute.Name = "execute";
            execute.Size = new Size(225, 69);
            execute.TabIndex = 3;
            execute.Text = "计算";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // label_distance
            // 
            label_distance.AutoSize = true;
            label_distance.Location = new Point(284, 231);
            label_distance.Name = "label_distance";
            label_distance.Size = new Size(92, 46);
            label_distance.TabIndex = 4;
            label_distance.Text = "路程";
            // 
            // label_speed
            // 
            label_speed.AutoSize = true;
            label_speed.Location = new Point(896, 231);
            label_speed.Name = "label_speed";
            label_speed.Size = new Size(92, 46);
            label_speed.TabIndex = 5;
            label_speed.Text = "速度";
            // 
            // label_time
            // 
            label_time.AutoSize = true;
            label_time.Location = new Point(1356, 231);
            label_time.Name = "label_time";
            label_time.Size = new Size(92, 46);
            label_time.TabIndex = 6;
            label_time.Text = "时间";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(22F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1995, 1177);
            Controls.Add(label_time);
            Controls.Add(label_speed);
            Controls.Add(label_distance);
            Controls.Add(execute);
            Controls.Add(TB_time);
            Controls.Add(TB_speed);
            Controls.Add(TB_distance);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_distance;
        private TextBox TB_speed;
        private TextBox TB_time;
        private Button execute;
        private Label label_distance;
        private Label label_speed;
        private Label label_time;
    }
}
