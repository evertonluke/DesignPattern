using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod.RealWorld
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Document
    {
        /// <summary>
        /// Factory Method implamentation
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
