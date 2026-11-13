namespace SIMS.SimsDB.Entities
{
    public class User
    {
        // dinh nghia cac thuoc tinh cua class chinh la cac cot trong bang "Users"
        // Ten cua cac cot trong bang "Users" viet nhu the nao thi o day viet dung theo nhu vay

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string Role { get; set; } = "Student";
        public byte Status { get; set; } = 0;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
