using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBasics
{
	//Création d'une classe Player

    public class Player
    {


		// variable identifiant du joueur
		private int _id;
        
		// variable nom du joueur
		private string _name;

		// variable numéro d'équipe du joueur
		private int _number;

		// Class Player attribuant le numéro du player
		public Player() { 

			// Assignation du numéro de l'équipe à -1
			_number = -1;

			// Assignation du nom de joueur



		}



        // Attribution des paramètres id et name depuis le constructeur player


		public Player(int id, string name)
		{
			// attribution de classe _id au paramètre int id
			_id = id;
			// attribution de classe _name au paramètre string name
			_name = name;

		}


		/// <summary>
		/// 
		/// </summary>
		/// 
		// Pour récupérer les valeurs pour la validations de test

		// Récupérer la valeur du nom de l'attribution de classe _name
		public string Name { get => _name; set => _name = value; }
		// Récupérer la valeur de l'id l'attribution de classe _id
		public int Id { get => _id; set => _id = value; }
		// Récupérer la valeur d l'attribution de classe _number
		public int Number { get => _number; set => _number = value; }
		





	



	}
}
