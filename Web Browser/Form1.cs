using System;
using System.Windows.Forms;
using CefSharp.WinForms;
using CefSharp;

namespace Web_Browser
{
	public partial class WebSpace : Form
	{
		public WebSpace()
		{
			InitializeComponent();
		}

		ChromiumWebBrowser chrome;
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (chrome.CanGoBack)
			{
				chrome.Back();
			}
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			if (chrome.CanGoForward)
			{
				chrome.Forward();
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
            chrome.Reload(ignoreCache: true);
            chrome.Refresh();
        }

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			chrome.Load(SearchURLBOX.Text);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CefSettings settings = new CefSettings();
			Cef.Initialize(settings);
			SearchURLBOX.Text = "https://www.bing.com";
			chrome = new ChromiumWebBrowser(SearchURLBOX.Text);
			this.BTab.Controls.Add(chrome);
			chrome.Dock = DockStyle.Fill;
			chrome.AddressChanged += Chrome_AddressChanged;
        }

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			sideBar1.BookmarkList.Items.Add(SearchURLBOX.Text);
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			chrome.Load(sideBar1.HomeSet.Text);
		}
		
		private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
		{
			this.Invoke(new MethodInvoker(() =>
			{
				SearchURLBOX.Text = e.Address;
			}
			));
		}

        private void SettingsButton_Click(object sender, EventArgs e)
        {
			// TODO
            ;
        }

		private void SubtractBookmarkButton_Click_1(object sender, EventArgs e)
		{
			sideBar1.BookmarkList.Items.Clear();
		}

		private void SearchURLBOX_KeyUp(object sender, KeyEventArgs e)
		{
            if (e.KeyCode == Keys.Enter)
            {
				chrome.Load(SearchURLBOX.Text);
            }
        }

        public void CloseSide()
        {
            sideBar1.Visible = false;
        }
    }
}
