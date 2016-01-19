export default class HeroesCtrl {
    constructor(heroes, $state, currency) {
        this.heroes = heroes;
        this.currency = currency;
        this.state = $state;
    }

    getDetails(hero) {
        return this.state.go("heroes.detailed", { id: hero.id });
    }
}