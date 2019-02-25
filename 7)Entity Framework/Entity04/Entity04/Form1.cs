using System;
using System.Windows.Forms;
using Entity04.Entity;
using System.Collections.Generic;

namespace Entity04 {
   public partial class Form1 : Form {
      public Form1() {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e) {
         DBCord Cord = new DBCord();

         List<Actor> players = new List<Actor>();

         Actor act1 = new Actor();
         act1.actorFullName = "Smart"; act1.actorBirthday = DateTime.Today;
         Cord.Actors.Add(act1);
         players.Add(act1);

         Actor act2 = new Actor();
         act2.actorFullName = "Pro"; act2.actorBirthday = DateTime.Today;
         Cord.Actors.Add(act2);
         players.Add(act2);

         Director dir = new Director();
         dir.directorName = "SP";
         Cord.Directors.Add(dir);

         Movie mov = new Movie();
         mov.movieName = "Orville"; mov.movieDirectorID = dir; mov.movieActorsID = players;
         Cord.Movies.Add(mov); Cord.SaveChanges();
      }
   }
}
