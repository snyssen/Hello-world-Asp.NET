using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Hello_worldTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void ObtenirLaMeteoDuJour_AvecUnBouchon_RetourneSoleil()
		{
			Meteo fausseMeteo = new Meteo
			{
				Temperature = 25,
				Temps = Temps.Soleil
			};
			Mock<IDal> mock = new Mock<IDal>();
			mock.Setup(dal => dal.ObtenirLaMeteoDuJour()).Returns(fausseMeteo);

			IDal fausseDal = mock.Object;
			Meteo meteoDuJour = fausseDal.ObtenirLaMeteoDuJour();
			Assert.AreEqual(25, meteoDuJour.Temperature);
			Assert.AreEqual(Temps.Soleil, meteoDuJour.Temps);
		}

		[TestMethod]
		public void Generateur_AvecUnBouchon_Retourne5()
		{
			Mock<IGenerateur> mock = new Mock<IGenerateur>();
			mock.Setup(generateur => generateur.Valeur).Returns(5);

			Assert.AreEqual(5, mock.Object.Valeur);
		}
	}
}
