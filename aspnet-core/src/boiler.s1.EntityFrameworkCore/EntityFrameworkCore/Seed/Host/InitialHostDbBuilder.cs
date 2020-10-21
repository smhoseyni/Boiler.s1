namespace boiler.s1.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly s1DbContext _context;

        public InitialHostDbBuilder(s1DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
