using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewApp.Model
{
    class StoredAstroObjects
    {
        public ObservableCollection<AstroObject> AllAstroObjects { get; set; }
        public StoredAstroObjects()
        {
            AllAstroObjects = new ObservableCollection<AstroObject>
            {
                new AstroObject { Name = "Země", Type = "Planeta", Description = "Planeta sluneční soustavy" },
                new AstroObject { Name = "Phobos", Type = "Měsíc", Description = "Měsíc planety Mars" },
                new AstroObject { Name = "Slunce", Type = "Hvězda", Description = "Nejbližší hvězda k Zemi" }
            };
        }
    }
}
