using System.ComponentModel.DataAnnotations;

namespace PowerAutomation.Models
{
    /// <summary>
    /// An automation procedure
    /// </summary>
    public class Procedure : IProcedure
    {
        private IProcedure[] _actions = new IProcedure[0];
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Key { get; set; }

        [Required]
        public IProcedure[] Procedures
        {
            get { return _actions; }
            set
            {
                ThrowIfCircularReference(value);
                _actions = value;
            }
        }

        public string Title { get; set; } = string.Empty;

        private void ThrowIfCircularReference(IProcedure[] procedures, string pedigree = "")
        {
            for (var i = 0; i < procedures.Length; i++)
            {
                var procedure = procedures[i];
                if (procedure == this) throw new Exception($"Procedure may contain itself. Circular reference found:\n     {pedigree}[{i}]");
                if (procedure is Procedure p) ThrowIfCircularReference(p.Procedures, $"[{i}]"); //search recursively
            }
        }
    }
}