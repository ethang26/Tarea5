using Microsoft.EntityFrameworkCore;
using Tarea1.Models;

namespace Tarea1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Planta> Plantas => Set<Planta>();

        protected override void OnModelCreating(ModelBuilder mb)
        {
            // Semilla: 50 plantas (imágenes con picsum para que carguen siempre; cambia a URLs reales cuando quieras)
            mb.Entity<Planta>().HasData(
                new Planta{ Id=1,  Nombre="Papa", Origen="Andes del Perú", Especie="Solanum tuberosum", Altura_Maxima=0.6m, Notas="Tubérculo andino base de la cocina peruana.", Imagen="https://picsum.photos/seed/papa/800/500"},
                new Planta{ Id=2,  Nombre="Oca", Origen="Sierra sur", Especie="Oxalis tuberosa", Altura_Maxima=0.3m, Notas="Tubérculo dulce, se consume sancochado o al horno.", Imagen="https://picsum.photos/seed/oca/800/500"},
                new Planta{ Id=3,  Nombre="Mashua", Origen="Andes centrales", Especie="Tropaeolum tuberosum", Altura_Maxima=0.4m, Notas="Tubérculo aromático tradicional.", Imagen="https://picsum.photos/seed/mashua/800/500"},
                new Planta{ Id=4,  Nombre="Olluco", Origen="Altiplano", Especie="Ullucus tuberosus", Altura_Maxima=0.4m, Notas="Tubérculo de colores vivos, rico en agua.", Imagen="https://picsum.photos/seed/olluco/800/500"},
                new Planta{ Id=5,  Nombre="Kiwicha", Origen="Andes", Especie="Amaranthus caudatus", Altura_Maxima=2.0m, Notas="Grano andino alto en proteína.", Imagen="https://picsum.photos/seed/kiwicha/800/500"},
                new Planta{ Id=6,  Nombre="Quinua", Origen="Altiplano", Especie="Chenopodium quinoa", Altura_Maxima=2.0m, Notas="Pseudo-cereal andino, versátil y nutritivo.", Imagen="https://picsum.photos/seed/quinua/800/500"},
                new Planta{ Id=7,  Nombre="Tarwi", Origen="Andes", Especie="Lupinus mutabilis", Altura_Maxima=2.5m, Notas="Lupino andino rico en proteína y aceite.", Imagen="https://picsum.photos/seed/tarwi/800/500"},
                new Planta{ Id=8,  Nombre="Maca", Origen="Junín – Meseta de Bombón", Especie="Lepidium meyenii", Altura_Maxima=0.2m, Notas="Raíz andina de uso alimenticio y tradicional.", Imagen="https://picsum.photos/seed/maca/800/500"},
                new Planta{ Id=9,  Nombre="Yacón", Origen="Andes orientales", Especie="Smallanthus sonchifolius", Altura_Maxima=2.0m, Notas="Raíz dulce con fructooligosacáridos.", Imagen="https://picsum.photos/seed/yacon/800/500"},
                new Planta{ Id=10, Nombre="Aji Amarillo", Origen="Valles interandinos", Especie="Capsicum baccatum", Altura_Maxima=1.5m, Notas="Base del sabor peruano, picor medio.", Imagen="https://picsum.photos/seed/ajiamarillo/800/500"},
                new Planta{ Id=11, Nombre="Rocoto", Origen="Andes húmedos", Especie="Capsicum pubescens", Altura_Maxima=2.5m, Notas="Ají de pared gruesa y semillas negras.", Imagen="https://picsum.photos/seed/rocoto/800/500"},
                new Planta{ Id=12, Nombre="Cochinilla (Nopal hospedero)", Origen="Costa sur", Especie="Opuntia ficus-indica", Altura_Maxima=3.0m, Notas="Cacto hospedero del tinte natural cochinilla.", Imagen="https://picsum.photos/seed/opuntia/800/500"},
                new Planta{ Id=13, Nombre="Coca", Origen="Ceja de selva", Especie="Erythroxylum coca", Altura_Maxima=3.0m, Notas="Uso tradicional andino en acullico e infusiones.", Imagen="https://picsum.photos/seed/coca/800/500"},
                new Planta{ Id=14, Nombre="Cacao", Origen="Amazonía peruana", Especie="Theobroma cacao", Altura_Maxima=8.0m, Notas="Base del chocolate fino de aroma.", Imagen="https://picsum.photos/seed/cacao/800/500"},
                new Planta{ Id=15, Nombre="Camu Camu", Origen="Riberas amazónicas", Especie="Myrciaria dubia", Altura_Maxima=5.0m, Notas="Fruto con altísimo contenido de vitamina C.", Imagen="https://picsum.photos/seed/camu/800/500"},
                new Planta{ Id=16, Nombre="Aguaje", Origen="Aguajales de la Amazonía", Especie="Mauritia flexuosa", Altura_Maxima=35.0m, Notas="Palmera icónica, fruto muy consumido.", Imagen="https://picsum.photos/seed/aguaje/800/500"},
                new Planta{ Id=17, Nombre="Sacha Inchi", Origen="Selva alta", Especie="Plukenetia volubilis", Altura_Maxima=2.0m, Notas="Semilla oleaginosa rica en omega 3.", Imagen="https://picsum.photos/seed/sachainchi/800/500"},
                new Planta{ Id=18, Nombre="Chirimoya", Origen="Valles andinos", Especie="Annona cherimola", Altura_Maxima=9.0m, Notas="Fruta de pulpa cremosa y dulce.", Imagen="https://picsum.photos/seed/chirimoya/800/500"},
                new Planta{ Id=19, Nombre="Lúcuma", Origen="Costa y sierra", Especie="Pouteria lucuma", Altura_Maxima=15.0m, Notas="Fruta harinosa, icónica en postres peruanos.", Imagen="https://picsum.photos/seed/lucuma/800/500"},
                new Planta{ Id=20, Nombre="Achiote", Origen="Amazonía", Especie="Bixa orellana", Altura_Maxima=6.0m, Notas="Fuente de annatto para colorante natural.", Imagen="https://picsum.photos/seed/achiote/800/500"},
                new Planta{ Id=21, Nombre="Huacatay", Origen="Valles interandinos", Especie="Tagetes minuta", Altura_Maxima=1.5m, Notas="Hierba aromática para ocopa y ajíes.", Imagen="https://picsum.photos/seed/huacatay/800/500"},
                new Planta{ Id=22, Nombre="Paico", Origen="Andes", Especie="Dysphania ambrosioides", Altura_Maxima=1.2m, Notas="Uso tradicional digestivo y culinario.", Imagen="https://picsum.photos/seed/paico/800/500"},
                new Planta{ Id=23, Nombre="Yuca", Origen="Amazonía", Especie="Manihot esculenta", Altura_Maxima=3.0m, Notas="Raíz rica en almidón; base en la selva.", Imagen="https://picsum.photos/seed/yuca/800/500"},
                new Planta{ Id=24, Nombre="Totora", Origen="Lagos altoandinos", Especie="Schoenoplectus tatora", Altura_Maxima=4.0m, Notas="Usada en islas flotantes y artesanías.", Imagen="https://picsum.photos/seed/totora/800/500"},
                new Planta{ Id=25, Nombre="Tara", Origen="Costa y sierra", Especie="Caesalpinia spinosa", Altura_Maxima=8.0m, Notas="Vaina rica en taninos (curtiembre).", Imagen="https://picsum.photos/seed/tara/800/500"},
                new Planta{ Id=26, Nombre="Algarrobo", Origen="Costa norte", Especie="Prosopis pallida", Altura_Maxima=20.0m, Notas="Sombrío y melífero; algarrobina.", Imagen="https://picsum.photos/seed/algarrobo/800/500"},
                new Planta{ Id=27, Nombre="Guayaba", Origen="Selva baja", Especie="Psidium guajava", Altura_Maxima=8.0m, Notas="Fruta aromática para jugos y mermeladas.", Imagen="https://picsum.photos/seed/guayaba/800/500"},
                new Planta{ Id=28, Nombre="Papaya", Origen="Tropico americano", Especie="Carica papaya", Altura_Maxima=6.0m, Notas="Fruta dulce, uso fresco y en jugos.", Imagen="https://picsum.photos/seed/papaya/800/500"},
                new Planta{ Id=29, Nombre="Ciruelo de fraile", Origen="Costa central", Especie="Capparis scabrida", Altura_Maxima=4.0m, Notas="Arbusto costero de floración vistosa.", Imagen="https://picsum.photos/seed/capparis/800/500"},
                new Planta{ Id=30, Nombre="Molle", Origen="Valles secos", Especie="Schinus molle", Altura_Maxima=15.0m, Notas="Árbol aromático ornamental y medicinal.", Imagen="https://picsum.photos/seed/molle/800/500"},
                new Planta{ Id=31, Nombre="Sauco andino", Origen="Andes", Especie="Sambucus peruviana", Altura_Maxima=8.0m, Notas="Frutos para jarabes y mermeladas.", Imagen="https://picsum.photos/seed/sauco/800/500"},
                new Planta{ Id=32, Nombre="Cañihua", Origen="Altiplano", Especie="Chenopodium pallidicaule", Altura_Maxima=0.6m, Notas="Grano andino resistente a heladas.", Imagen="https://picsum.photos/seed/canihua/800/500"},
                new Planta{ Id=33, Nombre="Uña de gato", Origen="Selva", Especie="Uncaria tomentosa", Altura_Maxima=30.0m, Notas="Liana de uso medicinal tradicional.", Imagen="https://picsum.photos/seed/unadegato/800/500"},
                new Planta{ Id=34, Nombre="Ayahuasca", Origen="Selva", Especie="Banisteriopsis caapi", Altura_Maxima=30.0m, Notas="Liana amazónica de uso ritual.", Imagen="https://picsum.photos/seed/ayahuasca/800/500"},
                new Planta{ Id=35, Nombre="Pejibaye (Chonta)", Origen="Selva", Especie="Bactris gasipaes", Altura_Maxima=20.0m, Notas="Palmera de palmito y fruto comestible.", Imagen="https://picsum.photos/seed/chonta/800/500"},
                new Planta{ Id=36, Nombre="Huayruro", Origen="Selva baja", Especie="Ormosia coccinea", Altura_Maxima=25.0m, Notas="Semillas rojas usadas en artesanías.", Imagen="https://picsum.photos/seed/huayruro/800/500"},
                new Planta{ Id=37, Nombre="Capulí", Origen="Sierra norte", Especie="Prunus serotina subsp. capuli", Altura_Maxima=10.0m, Notas="Fruta dulce morada, usos en chicha.", Imagen="https://picsum.photos/seed/capuli/800/500"},
                new Planta{ Id=38, Nombre="Muna", Origen="Andes", Especie="Minthostachys mollis", Altura_Maxima=1.2m, Notas="Aromática andina digestiva.", Imagen="https://picsum.photos/seed/muna/800/500"},
                new Planta{ Id=39, Nombre="Quinquina (Cinchona)", Origen="Selva alta", Especie="Cinchona officinalis", Altura_Maxima=15.0m, Notas="Corteza con alcaloides (quinina).", Imagen="https://picsum.photos/seed/cinchona/800/500"},
                new Planta{ Id=40, Nombre="Ñora andina (Ají panca)", Origen="Costa", Especie="Capsicum chinense var. panca", Altura_Maxima=1.2m, Notas="Ají seco, sabor ahumado suave.", Imagen="https://picsum.photos/seed/panca/800/500"},
                new Planta{ Id=41, Nombre="Copaiba", Origen="Selva baja", Especie="Copaifera officinalis", Altura_Maxima=30.0m, Notas="Árbol resinoso de uso medicinal.", Imagen="https://picsum.photos/seed/copaiba/800/500"},
                new Planta{ Id=42, Nombre="Shihuahuaco", Origen="Amazonía", Especie="Dipteryx micrantha", Altura_Maxima=50.0m, Notas="Árbol emblemático de madera dura.", Imagen="https://picsum.photos/seed/shihuahuaco/800/500"},
                new Planta{ Id=43, Nombre="Palo de rosa", Origen="Selva", Especie="Aniba rosaeodora", Altura_Maxima=30.0m, Notas="Aceite esencial aromático.", Imagen="https://picsum.photos/seed/paloderosa/800/500"},
                new Planta{ Id=44, Nombre="Quishuar", Origen="Andes", Especie="Buddleja coriacea", Altura_Maxima=8.0m, Notas="Árbol altoandino resistente al frío.", Imagen="https://picsum.photos/seed/quishuar/800/500"},
                new Planta{ Id=45, Nombre="Queñual", Origen="Cordillera andina", Especie="Polylepis spp.", Altura_Maxima=12.0m, Notas="Bosques de altura de gran valor ecológico.", Imagen="https://picsum.photos/seed/quenual/800/500"},
                new Planta{ Id=46, Nombre="Maca roja", Origen="Junín", Especie="Lepidium meyenii (var. roja)", Altura_Maxima=0.2m, Notas="Variante de maca cultivada en altura.", Imagen="https://picsum.photos/seed/macar/800/500"},
                new Planta{ Id=47, Nombre="Arveja andina", Origen="Sierra", Especie="Pisum sativum (tradicional)", Altura_Maxima=1.0m, Notas="Leguminosa ampliamente cultivada.", Imagen="https://picsum.photos/seed/arveja/800/500"},
                new Planta{ Id=48, Nombre="Choclo andino", Origen="Valles interandinos", Especie="Zea mays (var. andina)", Altura_Maxima=2.8m, Notas="Mazorca grande para humitas y choclo con queso.", Imagen="https://picsum.photos/seed/choclo/800/500"},
                new Planta{ Id=49, Nombre="Zapallo loche", Origen="Costa norte", Especie="Cucurbita moschata var. loche", Altura_Maxima=0.6m, Notas="Icono gastronómico de Lambayeque.", Imagen="https://picsum.photos/seed/loche/800/500"},
                new Planta{ Id=50, Nombre="Ciruelo de Toyo", Origen="Costa sur", Especie="Cordia lutea", Altura_Maxima=4.0m, Notas="Arbusto costero muy florífero.", Imagen="https://picsum.photos/seed/cordia/800/500"}
            );
        }
    }
}
