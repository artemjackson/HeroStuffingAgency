export default class HeroDetailsCtrl {
    constructor(hero, heroService, $sce) {
        this.hero = hero;
        this.service = heroService;
        this.sce = $sce;
        this.detailedInfo = null;
    }

    uploadDetails() {
        this.service.getDetailedInfo(this.hero)
            .then(info => {
                const parsed = info.replace(/&lt;/g, "<").replace(/&gt;/g, ">");    // making html from xml
                this.detailedInfo = this.sce.trustAsHtml(parsed)
            });
    }
}