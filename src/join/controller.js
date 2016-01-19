export default class JoinCtrl {
    constructor(heroService, $state) {
        this.heroService = heroService;
        this.state = $state;
    }

    join(hero) {
        this.heroService.add(hero)
            .then(() => this.state.go("heroes"))
            .catch(console.err);
    }
}