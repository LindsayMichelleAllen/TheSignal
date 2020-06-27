public interface IProjectile : IWeapon
{
    float range {get; set;}
    int clipSize {get; set;}
    float reloadSpeed {get; set;}
    float fire();
    int reload();
}
