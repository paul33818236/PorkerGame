using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Porker
{
   
    public partial class frmPoker : Form
    {
        int totalMoney = 1000000; // 初始資金
        int betAmount = 0;

        PictureBox[] pic = new PictureBox[5];
        int[] allPoker = new int[52];
        int[] playerPoker = new int[5];

        private int GetOdds(string handType)
        {
            switch (handType)
            {
                case "皇家同花順": return 250;
                case "同花順": return 50;
                case "四條": return 25;
                case "葫蘆": return 9;
                case "同花": return 6;
                case "順子": return 4;
                case "三條": return 3;
                case "兩對": return 2;
                case "一對": return 1;
                default: return 0;
            }
        }


        private void InitializePoker()
        {
            // 動態產生5張牌
            for (int i = 0; i < 5; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Name = "pic" + i;
                pic[i].Image = Properties.Resources.back;
                pic[i].SizeMode = PictureBoxSizeMode.AutoSize;
                pic[i].Top = 30;
                pic[i].Left = 10 + ((pic[i].Width + 10) * i);
                pic[i].Visible = true;
                pic[i].Enabled = false;
                pic[i].Tag = "back";
                // 將 pic 丟至到 grpPorker 內
                this.grpPoker.Controls.Add(pic[i]);
                pic[i].MouseClick += new MouseEventHandler(pic_Click);
            }
        }
        public frmPoker()
        {
            InitializeComponent();
            InitializePoker();
            //btnDealCard.Enabled = false;
        }

        private void pic_Click(object sender, MouseEventArgs e)
        {
             PictureBox pic = (PictureBox)sender;
            // 取得 pic 的索引值
            int index = int.Parse(pic.Name.Replace("pic", ""));
            // 如果 pic 的 Tag 為 back，則將顯示撲克牌
            if (pic.Tag.ToString() == "back")
            {
                pic.Tag = "front";
                pic.Image = Properties.Resources.ResourceManager.GetObject($"pic{playerPoker[index] + 1}") as Image; 
            }
            else
            {
                pic.Tag = "back";
                pic.Image = Properties.Resources.back;
            }

            //PictureBox pic = (PictureBox)sender;
            //MessageBox.Show("你選擇了" + pic.Name);
        }


       
        private void Shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < allPoker.Length; i++)
            {
                int r = rand.Next(allPoker.Length);
                int temp = allPoker[r];
                allPoker[r] = allPoker[0];
                allPoker[0] = temp;
            }
        }
        private async void btnDealCard_Click(object sender, EventArgs e)
        {
            // 先將牌面蓋掉
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = Properties.Resources.back;
            }
            // 初始化52張牌
            for (int i = 0; i < 52; i++)
            {
                allPoker[i] = i;
            }
            // 洗牌
            Shuffle();
            await Task.Delay(500);
            // 發牌
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = Properties.Resources.ResourceManager.GetObject($"pic{allPoker[i] + 1}") as Image;
                playerPoker[i] = allPoker[i];
            }
            // 啟用所有牌的點擊事件
            for (int i = 0; i < 5; i++)
            {
                pic[i].Enabled = true;
                pic[i].Tag = "front";
            }
            btnChangeCard.Enabled = true;
        }

        private void btnChangeCard_Click(object sender, EventArgs e)
        {
            int cardIndex = 5;
            for (int i = 0; i < pic.Length; i++)
            {
                if (pic[i].Tag.ToString() == "back")
                {
                    playerPoker[i] = allPoker[cardIndex];
                    pic[i].Image = Properties.Resources.ResourceManager.GetObject($"pic{playerPoker[i] + 1}") as Image; 
                    pic[i].Tag = "front";
                    cardIndex++;
                }
            }
            // 禁用所有牌的點擊事件
            for (int i = 0; i < pic.Length; i++)
            {
                pic[i].Enabled = false;
            }
            btnCheck.Enabled = true;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string[] colorList = { "梅花", "方塊", "愛心", "黑桃" };
            string[] pointList = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            // 計錄目前五張撲克牌的花色和點數的陣列
            int[] pokerColor = new int[5];
            int[] pokerPoint = new int[5];
            // 將每張牌的顏色和點數分別存入 pokerColor 和 pokerPoint 陣列
            for (int i = 0; i < 5; i++)
            {
                pokerColor[i] = playerPoker[i] % 4;
                pokerPoint[i] = playerPoker[i] / 4;
            }
            // 統計 color 和 point 出現次數
            int[] colorCount = new int[4];
            int[] pointCount = new int[13];
            for (int i = 0; i < 5; i++)
            {
                int color = pokerColor[i];
                int point = pokerPoint[i];
                colorCount[color]++;
                pointCount[point]++;
            }
            // 排序 colorCount 和 pointCount 由大到小
            Array.Sort(colorCount, colorList);
            Array.Reverse(colorCount);
            Array.Reverse(colorList);
            Array.Sort(pointCount, pointList);
            Array.Reverse(pointCount);
            Array.Reverse(pointList);

            // 判斷是否為同花
            bool isFlush = (colorCount[0] == 5);
            // 判斷是否為五張單張
            bool isSingle = (pointCount[0] == 1 && pointCount[1] == 1 && pointCount[2] == 1 &&
            pointCount[3] == 1 && pointCount[4] == 1);
            // 判斷是否為差四
            bool isDiffFout = (pokerPoint.Max() - pokerPoint.Min() == 4);
            // 判斷是否為大順
            bool isRoyal = pokerPoint.Contains(0) && pokerPoint.Contains(9) &&
            pokerPoint.Contains(10) && pokerPoint.Contains(11) && pokerPoint.Contains(12);
            // 判斷是否為同花大順
            bool isRoyalisFlush = isFlush && isRoyal;
            // 判斷是否為同花順
            bool isStraightFlush = isFlush && isSingle && isDiffFout;
            // 判斷是否為順子
            bool isStraight = isSingle && (isDiffFout || isRoyal);
            // 判斷是否為鐵支
            bool isFourOfAKind = (pointCount[0] == 4);
            // 判斷是否為葫蘆
            bool isFullHouse = (pointCount[0] == 3 && pointCount[1] == 2);
            // 判斷是否為三條
            bool isThreeOfAKind = (pointCount[0] == 3 && pointCount[1] == 1);
            // 判斷是否為兩對
            bool isTwoPair = (pointCount[0] == 2 && pointCount[1] == 2);
            // 判斷是否為一對
            bool isOnePair = (pointCount[0] == 2 && pointCount[1] == 1);
            
            string result = "";
            string handType = "";
            if (isRoyalisFlush)
            {
                result = $"{colorList[0]} 同花大順";
                handType = "同花大順";
            }
            else if (isStraightFlush)
            {
                result = $"{colorList[0]} 同花順";
                handType = "同花順";
            }
            else if (isStraight)
            {
                result = "順子";
                handType = "順子";
            }
            else if (isFourOfAKind)
            {
                result = $"{pointList[0]} 鐵支";
                handType = "鐵支";
            }
            else if (isFullHouse)
            {
                result = $"{pointList[0]}三張{pointList[1]}兩張 葫蘆";
                handType = "葫蘆";
            }
            else if (isFlush)
            {
                result = $"{colorList[0]} 同花";
                handType = "同花";
            }
            else if (isThreeOfAKind)
            {
                result = $"{pointList[0]} 三條";
                handType = "三條";
            }
            else if (isTwoPair)
            {
                result = $"{pointList[0]},{pointList[1]} 兩對";
                handType = "兩對";
            }
            else if (isOnePair)
            {
                result = $"{pointList[0]} 一對";
                handType = "一對";
            }
            else
            {
                result = "雜牌";
                handType = "雜牌";
            }

            int odds = GetOdds(handType);
            int winMoney = betAmount * odds;
            totalMoney += winMoney;
            txtMoney.Text = totalMoney.ToString();
            betAmount = 0;

            lblResult.Text = result;
            btnChangeCard.Enabled = false;
            btnCheck.Enabled = false;
        }
        /// <summary>
        /// 顯示五張撲克牌到桌面上
        /// </summary>
        private void ShowCards()
        {
            for (int i = 0; i < 5; i++)
            {
                pic[i].Image = Properties.Resources.ResourceManager.GetObject($"pic{playerPoker[i] + 1}") as Image;
            }
        }
        private void frmPoker_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btnDealCard.Enabled == false)
            {
                switch ((int)e.KeyChar)
                {
                    case 113: // q鍵
                              // 同花大順
                        playerPoker[0] = 51;
                        playerPoker[1] = 47;
                        playerPoker[2] = 43;
                        playerPoker[3] = 39;
                        playerPoker[4] = 3;
                        break;
                    case 119: // w鍵
                              // 同花順
                        playerPoker[0] = 37;
                        playerPoker[1] = 33;
                        playerPoker[2] = 29;
                        playerPoker[3] = 25;
                        playerPoker[4] = 21;
                        break;
                    case 101: // e鍵
                              // 同花
                        playerPoker[0] = 50;
                        playerPoker[1] = 38;
                        playerPoker[2] = 34;
                        playerPoker[3] = 22;
                        playerPoker[4] = 18;
                        break;
                    case 114: // r鍵
                              // 鐵支
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 38;
                        playerPoker[3] = 37;
                        playerPoker[4] = 36;
                        break;
                    case 116: // t鍵
                              // 葫蘆
                        playerPoker[0] = 30;
                        playerPoker[1] = 29;
                        playerPoker[2] = 6;
                        playerPoker[3] = 5;
                        playerPoker[4] = 4;
                        break;
                    case 121: // y鍵
                              // 三條
                        playerPoker[0] = 48;
                        playerPoker[1] = 39;
                        playerPoker[2] = 15;
                        playerPoker[3] = 14;
                        playerPoker[4] = 13;
                        break;
                }
                // 顯示五張撲克牌到桌面上
                ShowCards();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBet.Text, out betAmount) || betAmount <= 0)
            {
                MessageBox.Show("請輸入正確的下注金額！");
                return;
            }

            if (betAmount > totalMoney)
            {
                MessageBox.Show("下注金額不可大於目前資金！");
                return;
            }

            totalMoney -= betAmount;
            txtMoney.Text = totalMoney.ToString();

            MessageBox.Show("下注成功！");
        }
    }
}
