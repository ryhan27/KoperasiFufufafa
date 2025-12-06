namespace BraveHeroCooperation.Forms.AdminMenus
{
    internal class MemberService
    {
        private AppDbContext db;

        public MemberService(AppDbContext db)
        {
            this.db = db;
        }
    }
}