namespace Code_first_entity_framework_example_asp_dot_net.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Code_first_entity_framework_example_asp_dot_net.BlogginContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Code_first_entity_framework_example_asp_dot_net.BlogginContext";
        }

        protected override void Seed(Code_first_entity_framework_example_asp_dot_net.BlogginContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
