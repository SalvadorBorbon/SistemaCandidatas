namespace SistemaCandidatas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidatas",
                c => new
                    {
                        pkCandidata = c.Int(nullable: false, identity: true),
                        sAnioConvocatoria = c.Int(nullable: false),
                        sNombre = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        fNacimiento = c.DateTime(nullable: false, precision: 0),
                        sDescripcion = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        sEmail = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        sCurp = c.String(nullable: false, maxLength: 18, storeType: "nvarchar"),
                        sEstudios = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        sFoto = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        iLike = c.Int(nullable: false),
                        fkMunicipio_pkMunicipio = c.Int(),
                        Usuario_pkUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.pkCandidata)
                .ForeignKey("dbo.Municipios", t => t.fkMunicipio_pkMunicipio)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_pkUsuario)
                .Index(t => t.fkMunicipio_pkMunicipio)
                .Index(t => t.Usuario_pkUsuario);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        pkMunicipio = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        sDescripcion = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        sLogo = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkMunicipio);
            
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        pkPermiso = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 25, storeType: "nvarchar"),
                        sDescripcion = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.pkPermiso);
            
            CreateTable(
                "dbo.PermisosNegados",
                c => new
                    {
                        pkPermisoNegado = c.Int(nullable: false, identity: true),
                        permiso_pkPermiso = c.Int(),
                        rol_pkRoles = c.Int(),
                    })
                .PrimaryKey(t => t.pkPermisoNegado)
                .ForeignKey("dbo.Permisos", t => t.permiso_pkPermiso)
                .ForeignKey("dbo.Roles", t => t.rol_pkRoles)
                .Index(t => t.permiso_pkPermiso)
                .Index(t => t.rol_pkRoles);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        pkRoles = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        sDescripcion = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkRoles);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        pkUsuario = c.Int(nullable: false, identity: true),
                        sUsuario = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        sNombre = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        sPassword = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        bStatus = c.Boolean(nullable: false),
                        rol_pkRoles = c.Int(),
                    })
                .PrimaryKey(t => t.pkUsuario)
                .ForeignKey("dbo.Roles", t => t.rol_pkRoles)
                .Index(t => t.rol_pkRoles);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PermisosNegados", "rol_pkRoles", "dbo.Roles");
            DropForeignKey("dbo.Usuarios", "rol_pkRoles", "dbo.Roles");
            DropForeignKey("dbo.Candidatas", "Usuario_pkUsuario", "dbo.Usuarios");
            DropForeignKey("dbo.PermisosNegados", "permiso_pkPermiso", "dbo.Permisos");
            DropForeignKey("dbo.Candidatas", "fkMunicipio_pkMunicipio", "dbo.Municipios");
            DropIndex("dbo.Usuarios", new[] { "rol_pkRoles" });
            DropIndex("dbo.PermisosNegados", new[] { "rol_pkRoles" });
            DropIndex("dbo.PermisosNegados", new[] { "permiso_pkPermiso" });
            DropIndex("dbo.Candidatas", new[] { "Usuario_pkUsuario" });
            DropIndex("dbo.Candidatas", new[] { "fkMunicipio_pkMunicipio" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
            DropTable("dbo.PermisosNegados");
            DropTable("dbo.Permisos");
            DropTable("dbo.Municipios");
            DropTable("dbo.Candidatas");
        }
    }
}
