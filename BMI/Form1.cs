namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        private double fBMICal(double dCM, double dKG)
        {
            double dRet = dKG / (dCM * dCM);

            return Math.Round(dRet, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double dCM = double.Parse(tboxCM.Text) / 100; //미터 변환
                double dKG = double.Parse(tboxKG.Text);

                double dRet = fBMICal(dCM, dKG);

                int iRet = (int)(dRet * 10);

                if (iRet < 150)
                {
                    iRet = 150;
                }
                else if (280 < iRet)
                {
                    iRet = 280;
                }

                tbarRet.Value = iRet;

                string strRet = fCalResult(dRet);

                lblRet.Text = $" ※ BMI 지수 [{dRet}]로 비만도 결과 [{strRet}]입니다.";

                UpdateHelpfulVideoLink(strRet);
            }
            catch (Exception ex)
            {
                lblRet.Text = ex.ToString();
            }
        }
        private string fCalResult(double dRet)
        {
            string strRet = string.Empty;

            if (dRet < 18.5)
            {
                strRet = "저체중";
            }
            else if (18.5 <= dRet && dRet < 23)
            {
                strRet = "정상";
            }
            else if (23 <= dRet && dRet < 25)
            {
                strRet = "과체중";
            }
            else if (25 <= dRet)
            {
                strRet = "비만";
            }

            return strRet;
        }
        private void UpdateHelpfulVideoLink(string category)
        {
            string videoLink = "";

            if (category == "저체중")
            {
                videoLink = "https://www.youtube.com/watch?v=f8IPr0Et7oY";
            }
            else if (category == "과체중" || category == "비만")
            {
                videoLink = "https://www.youtube.com/watch?v=DQrsQiqphkg";
            }

            lblVideoLink.Text = videoLink;
            lblVideoLink.Links.Clear();
            lblVideoLink.Links.Add(0, videoLink.Length, videoLink);
        }

        private void lblVideoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string url = lblVideoLink.Text;
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }
    }
}