namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void Main(string[] args)
    {
        string[] auto = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };
        Console.WriteLine("Liste des véhicules disponibles dans le garage: ");
        for (int i = 0; i < auto.Length; i++)
        {
            Console.WriteLine(auto[i]);
        }
    }
}