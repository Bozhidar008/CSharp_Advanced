using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        List<Renovator> renovators = new List<Renovator>();

        public Catalog(string name, int neededRenovators, string project)
        {
            
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count => renovators.Count;

        public string AddRenovator(Renovator renovator)
        {
           
            if ((renovator.Name == null || renovator.Name == string.Empty)|| (renovator.Type == null || renovator.Type == string.Empty))
            {
                return "Invalid renovator's information.";
            }
            else if (Count >= NeededRenovators)
            {
                return "Renovators are no more needed.";
            }
            else if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }
            else
            {
                renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }   
            
        }

        public bool RemoveRenovator( string name)
        {
            var isExist = renovators.FirstOrDefault(r=>r.Name == name);
            if (isExist != null)
            {
                renovators.Remove(isExist);
                return true;
            }
            return false;
        }
        
        public int RemoveRenovatorBySpecialty(string type)
        {
            int result = renovators.Where(r=>r.Type == type).Count();
            
            return result;
        }

        public Renovator HireRenovator(string name)
        {
            var isExist = renovators.FirstOrDefault(r => r.Name == name);
            if (isExist != null)
            {
                isExist.Hired = true;
                    return isExist;
            }
            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
            var result = renovators.Where(r=>r.Days >= days).ToList();
            return result;
        }

        public string Report()
        {
            var result = new StringBuilder();
            result.AppendLine($"Renovators available for Project {Project}:");
            foreach (var item in renovators.Where(r=>r.Hired == false))
            {
                result.AppendLine(item.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}
