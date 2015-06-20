# ToasterWithAsp.NetMvc

Toastr est une librairie javascript qui permet de créer des notifications non-blocking sur le site web. Voici un démo sur toastr: toastr exemple

Dans cet article, je vous fait un exemple comment on utilise Toast côté serveur (dans ASP.NET MVC) pour afficher des notifications de ce type à la demande.

Etape 1: Créer un nouveau projet ASP.NET MVC (j’ai utilisé VS 2013)

Etape 2: Télécharger toastr depuis ce site toastr.

Puis, ajouter les deux fichiers toastr.min.js, toastr.min.map dans le répertoire /Scripts et ajouter le fichier toastr.min.css dans le répertoire /Content/css
Ouvrir le fichier App_Start/BundleConfig et y ajouter la référence vers ces fichiers. Ici, j’ai créé un nouveau script bundle pour toastr.min.js et j’ai ajouté toastr.min.css dans bundle existant.
bundle

Ajouter la ligne suivante dans ~Views/Shared/_Layout.cshtml pour générer le script pour toastrscript
ou alors vous pourriez ajouter directement les CDN de ces fichiers:
//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js
//cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css
Etape 3: créer modèle pour contenir message affiché

Créer une classe pour décrire le type de message affiché (success, info, warning, error) messageType
Créer une classe pour décrire le message soi-mêmemessage
Etape 4: créer le contrôleur qui gère ces messages

On crée un nouveau contrôleur appelé BaseController qui est contrôleur de base pour tous les autres contrôleurs de l’application
On y ajoute des méthodes nécessaires pour enregistrer le message et l’afficher à la vue
Première méthode: permet d’ajouter le message souhaité à l’objet TempData
addMessage

Deuxième méthode: permet de rendre le message enregistré dans TempData à la vue (appelé _OperationComplete)
rendreMessage

Etape 5: créer la vue _OperationMessage.cshtml pour afficher le message

On crée une vue partielle et la met dans répertoire ~/Views/Shared
Là, on récupère l’objet Message passé par le contrôleur (dans Model) et affiche son contenu utilisant toastrview
Etape 6: pour chaque contrôleur qui a besoin d’utiliser cette fonctionnalité, on modifie l’héritage du contrôleur vers BaseControler au lieu de Controler. Ensuite, on appelle la méthode pour enregistrer le message au moment qu’on souhaite.

controler

Etape finale: dans la vue, on définit la position pour afficher ce message en appelant @Html.Action(‘OperationComplete’). Cette ligne appelle la méthode OperationComplete de BaseControler. Cette dernière cherche le message enregistré dans TempData et l’afficher sur le site.

Lien de ref: https://nhattong.wordpress.com/2015/06/20/utilisation-toast-avec-asp-net-mvc/
