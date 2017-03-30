using Chatting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatting
{
    
    public partial class FacesForm : Form
    {
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 0x01;
            const int HTCAPTION = 0x02;
            const int WM_SYSCOMMAND = 0x112;
            const int SC_MAXMIZE = 0xF030;
            const int WM_NCLBUTTONDBLCLK = 0xA3;
            switch (m.Msg)
            {
                case 0x4e:
                case 0xd:
                case 0xe:
                case 0x14:
                    base.WndProc(ref m);
                    break;
                case WM_NCHITTEST://鼠标点任意位置后可以拖动窗体

                    this.DefWndProc(ref m);
                    if (m.Result.ToInt32() == HTCLIENT)
                    {
                        m.Result = new IntPtr(HTCAPTION);
                        return;
                    }
                    break;
                case WM_NCLBUTTONDBLCLK://禁止双击最大化
                    Console.WriteLine(this.WindowState);

                    return;
                    break;
                default:

                    base.WndProc(ref m);
                    break;
            }
        }
        public PersonalInfoForm personalInfoForm;  // 个人信息窗体
        public RegisterForm registerForm;
        public FacesForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lvFaces.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择一个头像！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int faceId = lvFaces.SelectedItems[0].ImageIndex;  // 获得当前选中的头像的索引
                if (personalInfoForm == null)
                {
                    registerForm.ShowFace(faceId);
                }
                else
                {
                    personalInfoForm.ShowFace(faceId);
                }
                this.Close();
            }
        }
        /*委托*/
     


        // 窗体加载时显示头像图片
        private void Facesform_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < ilFaces.Images.Count; i++)
            {
                lvFaces.Items.Add(i.ToString());
                lvFaces.Items[i].ImageIndex = i;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvFaces_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int faceId = lvFaces.SelectedItems[0].ImageIndex;  // 获得当前选中的头像的索引
            if (personalInfoForm == null)
            {
                registerForm.ShowFace(faceId);
            }
            else
            {
                personalInfoForm.ShowFace(faceId);
            }
            this.Close();
        }

    }
}
