using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace Antares.Essentials.Configuration
{
    public class OptionsBase
    {
        protected virtual string SectionName { get; set; }
        protected readonly IConfiguration Scope;

        public readonly IConfigurationSection CurrentSection;

        public OptionsBase(IConfiguration scope) 
        {
            Scope = scope;

            SectionName = this.GetType().Name.Replace("Options", string.Empty);
            CurrentSection = Scope?.GetSection(SectionName);
        }

        public OptionsBase(IConfiguration scope, string sectionName)
        {
            Scope = scope;

            SectionName = sectionName;
            CurrentSection = Scope?.GetSection(sectionName);
        }

        protected string GetString([CallerMemberName]string subKey = "")
        {
            return CurrentSection?[subKey];
        }

        protected int? GetInt([CallerMemberName]string subKey = "")
        {
            if (int.TryParse(CurrentSection?[subKey], out int i))
            {
                return i;
            }

            return null;
        }

        protected double? GetDecimal([CallerMemberName]string subKey = "")
        {
            if (double.TryParse(CurrentSection?[subKey], out double i))
            {
                return i;
            }

            return null;
        }

        protected bool? GetBoolean([CallerMemberName]string subKey = "")
        {
            if (bool.TryParse(CurrentSection?[subKey], out bool i))
            {
                return i;
            }

            return null;
        }

        public override string ToString()
        {
            return $"{GetType().Name} [SectionName={SectionName}]";
        }
    }
}
