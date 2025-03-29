#if (ImplicitUsings != "enable")
using Core.Arango;
using Core.Arango.Migration;
using Core.Arango.Protocol;

#endif
#if (csharpFeature_FileScopedNamespaces)
namespace Company.ClassLibrary1.Migrations;

public class Migration1 : IArangoMigration
{
    public long Id => 19990101000000L;
    public string Name => nameof(Migration1);

    public async Task Up(IArangoMigrator migrator, ArangoHandle db)
    {
        var state = await migrator.GetStructureAsync(db);
        // Apply the migration structure
        // This is a placeholder for the actual migration logic.
        // You can use the state to apply changes to the database.
        // For example, you might want to create collections, indexes, etc.
        await migrator.ApplyStructureAsync(db, state);
    }

    public async Task Down(IArangoMigrator migrator, ArangoHandle db)
    {
        var state = await migrator.GetStructureAsync(db);
        // Revert the migration structure
        // This is a placeholder for the actual rollback logic.
        // You can use the state to revert changes made in the Up method.
        // For example, you might want to drop collections, indexes, etc.
        // Note: Ensure that the rollback logic is safe and does not lead to data loss.
        await migrator.ApplyStructureAsync(db, state);
    }
}
#else
namespace Company.ClassLibrary1.Migrations
{
    public class Migration1 : IArangoMigration
    {
        public long Id => 19990101000000L;
        public string Name => nameof(Migration1);

        public async Task Up(IArangoMigrator migrator, ArangoHandle db)
        {
            var state = await migrator.GetStructureAsync(db);
        // Apply the migration structure
        // This is a placeholder for the actual migration logic.
        // You can use the state to apply changes to the database.
        // For example, you might want to create collections, indexes, etc.
            await migrator.ApplyStructureAsync(db, state);
        }

        public async Task Down(IArangoMigrator migrator, ArangoHandle db)
        {
            var state = await migrator.GetStructureAsync(db);
        // Revert the migration structure
        // This is a placeholder for the actual rollback logic.
        // You can use the state to revert changes made in the Up method.
        // For example, you might want to drop collections, indexes, etc.
        // Note: Ensure that the rollback logic is safe and does not lead to data loss.
            await migrator.ApplyStructureAsync(db, state);
        }
    }
}
#endif