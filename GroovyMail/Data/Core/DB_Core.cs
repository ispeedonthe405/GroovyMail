using System.Threading.Tasks;

namespace GroovyMail.Data.Core
{
    internal class DB_Core : DB_Base
    {
        public DB_Core() { }

        public override async Task Load()
        {
            await Task.Delay(1);
        }
    }
}
