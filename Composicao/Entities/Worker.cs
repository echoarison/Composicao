using Composicao.Entities.Enums;
using System.Collections.Generic;   //pegando aqui o List

namespace Composicao.Entities
{
    internal class Worker
    {
        //atributos
        private string _name;
        private WorkerLevel _level;
        private double _baseSalary;
        //composicao atributo
        private Department _department;
        //atributo composicao com list
        private List<HourContract> _contract = new List<HourContract>();   //para não ser null

        /**
         * 
         * Quando tiver uma associação de muitos vc não passa
         * para o construtor
         * 
         **/

        //construtor
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {

            _name = name;
            _level = level;
            _baseSalary = baseSalary;
            _department = department;

        }

        //Get e Set
        public string GetName()
        {

            return _name;

        }

        public void SetName(string name)
        {

            _name = name;

        }

        public WorkerLevel GetLevel()
        {

            return _level;

        }

        public void SetLevel(WorkerLevel level)
        {

            _level = level;

        }

        public double GetBaseSalary()
        {

            return _baseSalary;

        }

        public void SetBaseSalary(double baseSalary)
        {

            _baseSalary = baseSalary;

        }

        public Department GetDepartment()
        {

            return _department;

        }

        public void SetDepartment(Department department)
        {

            _department = department;

        }

        public List<HourContract> GetContracts()
        {

            return _contract;

        }

        public void SetContract(HourContract contracts)
        {

            _contract.Add(contracts);

        }   //adicionando o tipo objeto na lista


        //methods
        public void AddContract(HourContract contract)
        {

            /**
             * 
             * Aqui estou adicionando na minha lista atributo
             * contract
             * 
             **/
            SetContract(contract);



        }

        public void RemoveContract(HourContract contract)
        {

            _contract.Remove(contract);

        }

        public double Income(int year, int month)
        {
            double sum = _baseSalary;

            //percorrendo a lista do contract
            foreach (HourContract contract in _contract)
            {
                //só ta adicionando os contratos daquele ano e mes
                if (contract.GetDate().Year == year && contract.GetDate().Month == month)
                {
                    sum += contract.TotalValue();
                }

            }

            return sum;
        }
    }
}
