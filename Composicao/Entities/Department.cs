namespace Composicao.Entities
{
    internal class Department
    {
        //atributo
        private string _name;

        //construtor
        public Department()
        {
        }

        public Department(string name) { 
            
            _name = name;

        }

        //get e set
        public string GetName()
        {

            return _name;

        }

        public void SetName(string name)
        {

            _name = name;

        }

    }
}
