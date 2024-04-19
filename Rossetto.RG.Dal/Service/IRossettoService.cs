namespace Rossetto.RG.Dal.Service
{
    public interface IRossettoService
    {
        void AddEspion(string nom, string nomCode);
        void AddMission(string lieu, int annee);
        void AddMissionToEspion(int missionId, int espionId);
        void DeleteEspion(int id);
        void DeleteMission(int id);
        void EditEspion(int id, string nom, string nomCode);
        void EditMission(int id, string lieu, int annee);
        void ImportEspionsFromFichier(string url);
    }
}