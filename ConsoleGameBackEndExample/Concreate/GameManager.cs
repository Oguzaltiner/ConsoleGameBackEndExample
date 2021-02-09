using ConsoleGameBackEndExample.Abstract;
using ConsoleGameBackEndExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGameBackEndExample.Concreate
{
    public class GameManager : BaseGameManager
    {

        public override void Save(Game entity)
        {
            base.Save(entity);
        }
        public override void Delete(int id)
        {
            base.Delete(id);
        }
        public override void Update(Game entity)
        {
            base.Update(entity);
        }

    }
}
