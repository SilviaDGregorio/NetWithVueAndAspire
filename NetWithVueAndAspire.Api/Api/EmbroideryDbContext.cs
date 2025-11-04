using Microsoft.EntityFrameworkCore;

public class EmbroideryDbContext(DbContextOptions<EmbroideryDbContext> options) : DbContext(options)
{
    public DbSet<ImageEntity> Images { get; set; }
}
public class ImageEntity
{
    public int Id { get; set; }
    public required string Url { get; set; }

    public required string Description { get; set; }
}