using System;
using System.Threading.Tasks;

namespace GroovyMail.Data
{
    internal class DB_Base
    {
        ///////////////////////////////////////////////////////////
        #region Fields

        private string _Name = string.Empty;
        private string _Folder = string.Empty;
        private SQLite.SQLiteAsyncConnection? Connection;

        #endregion Fields
        ///////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////
        #region Properties

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public string Folder
        {
            get => _Folder;
            set => _Folder = value;
        }

        public string FullPath
        {
            get => System.IO.Path.Combine(_Folder, _Name);
        }

        #endregion Properties
        ///////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////
        #region Interface

        public DB_Base()
        {            
        }

        public void Open(string name, string folder)
        {
            Name = name;
            Folder = folder;

            if (!sbdotnet.IO.IsValidFilename(name))
            {
                sbdotnet.Logger.Error($"{name} is not a valid filename");
            }

            if (!sbdotnet.IO.IsValidPathname(folder))
            {
                sbdotnet.Logger.Error($"{folder} is not a valid folder name or path");
            }

            try
            {
                SQLite.SQLiteConnectionString cstring = new(FullPath);
                Connection = new(cstring);
            }
            catch (Exception ex)
            {
                sbdotnet.Logger.Error(ex);
            }
        }

        public async Task Close()
        {
            try
            {
                if (Connection is null) return;
                await Connection.CloseAsync();
            }
            catch(Exception ex)
            {
                sbdotnet.Logger.Error(ex);
            }
        }

        public virtual async Task Load()
        {
            // A little delay keeps the green squiggles away
            await Task.Delay(1);
            throw new NotImplementedException();
        }

        #endregion Interface
        ///////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////
        #region Internal



        #endregion Internal
        ///////////////////////////////////////////////////////////
    }
}
