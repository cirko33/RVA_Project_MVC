///////////////////////////////////////////////////////////
//  Dodeli.cs
//  Implementation of the Class Dodeli
//  Generated by Enterprise Architect
//  Created on:      29-Aug-2022 18:54:29
//  Original author: Luka
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using Classes;
namespace Classes {
	public class Dodeli : ConcreteCommand {

		public Dodeli(){

		}

        public Dodeli(DodelaLekara dodelaLekara, Pacijent pacijent, Lekar lekar) : base(dodelaLekara, pacijent, lekar)
        {
        }

        ~Dodeli(){

		}

		public override void Execute(){
			m_DodelaLekara.Dodeli(pacijent, lekar);
		}

		public override void Unexecute(){
			m_DodelaLekara.Odjavi(pacijent);
		}

	}//end Dodeli

}//end namespace Classes