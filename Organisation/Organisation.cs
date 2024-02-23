// https://docs.google.com/document/d/1JN0SjEeelhtpKzoJqkva5JRePiMCLzyYPcI0Je8m7qU/edit
namespace OrganisationLibrary
{
    public class Organisation
    {
        private string name;
        private string legalAdress;
        private string actualAdress;
        private string refSupervisor;
        public Organisation(string name, string legalAdress, string actualAdress, string refSupervisor)
        {
            this.name = name;
            this.legalAdress = legalAdress;
            this.actualAdress = actualAdress;
            this.refSupervisor = refSupervisor;
        }
    }
}
