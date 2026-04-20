using Microsoft.EntityFrameworkCore;
using IssueTracker.Models;

namespace IssueTracker.Data {
    public class IssueTrackerContext : DbContext {
        public IssueTrackerContext(DbContextOptions<IssueTrackerContext> options) : base(options) {
        }
        public DbSet<Issue> Issues { get; set; } = default!;
    }
}
