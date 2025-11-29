using BraveHeroCooperation.Data;
using BraveHeroCooperation.Models;
using BraveHeroCooperation.Services;
using KoperasiFufufafa.Models;
using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace BraveHeroCooperation.Forms.AdminMenus
{
    public partial class MemberPage : UserControl
    {
        public MemberPage()
        {
            InitializeComponent();
            this.Load += MemberPage_Load;
        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            loadGridMember();

            string? id = labelId.Text;
            if (string.IsNullOrEmpty(id) || id == "...")
            {
                buttonUpdate.Visible = false;
            }
        }

        private void loadGridMember()
        {
            AppDbContext db = new AppDbContext();
            MemberService service = new MemberService(db);
            var members = service.SetGrid();
            memberBindingSource.DataSource = members;

            dgvMemberx.Columns[0].DataPropertyName = "Id";
            dgvMemberx.Columns[0].Visible = false;

            dgvMemberx.Columns[1].DataPropertyName = "MemberId";
            dgvMemberx.Columns[2].DataPropertyName = "Fullname";
            dgvMemberx.Columns[3].DataPropertyName = "ModDate";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            MemberService service = new MemberService(db);
            if (int.TryParse(labelId.Text, out int memberId))
            {
                Member? member = service.FindById(memberId);
                if (member != null)
                {
                    member.IsActive = comboStatus.SelectedIndex == 0 ? true : false;
                    member.ModDate = DateTime.UtcNow;
                    service.Update(member);
                }
            }
            loadGridMember();
        }

        private void dgvMemberx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (int.TryParse(dgvMemberx.Rows[e.RowIndex].Cells[0].Value?.ToString(), out int memberId))
            {
                AppDbContext db = new AppDbContext();
                MemberService service = new MemberService(db);
                Member? member = service.FindById(memberId);

                if (member != null)
                {
                    labelFullName.Text = member.FullName;
                    labelEmail.Text = member.Email;
                    labelPhone.Text = member.Phone;
                    labelPhoneAlt.Text = member.PhoneAlt;
                    labelAddress.Text = member.Address;
                    labelJoinDate.Text = member.JoinDate.ToString("f");
                    labelMemberId.Text = member.MemberId;
                    labelCardId.Text = member.IdCard;
                    labelId.Text = member.Id.ToString();

                    comboStatus.SelectedIndex = member.IsActive ? 0 : 1;
                    buttonUpdate.Visible = true;
                }
                else
                {
                    buttonUpdate.Visible = false;
                }
            }
        }
    }
}
