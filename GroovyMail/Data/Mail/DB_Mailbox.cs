using System.Threading.Tasks;

namespace GroovyMail.Data.Mail
{
    internal class DB_Mailbox : DB_Base
    {
        public DB_Mailbox() { }

        public override async Task Load()
        {
            await Task.Delay(1);
        }
    }
}
