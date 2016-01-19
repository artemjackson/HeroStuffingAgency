export default class HeroService {
    constructor($http) {
        this.http = $http;
    }

    add(hero) {
        const photo = hero.photo;   // extractin photofrom hero

        delete hero.photo;          // and excluding it from hero object
        
        return this.http.post("/api/heroes", hero)
            .then(response => {
                if (photo) {
                    const id = response.data;

                    var fd = new FormData();
                    fd.append('file', photo);

                    return this.http.post(`/api/heroes/${id}/photo`, fd, {
                        headers: { 'Content-Type': undefined },
                        transformRequest: angular.identity,
                    });
                }
            })
            .catch(err => console.error);
    }

    getDetailedInfo(hero) {
        return this.http.get(`/api/heroesinfo/${hero.pseudonym}`)
            .then(response => response.data);
    }

    getAll() {
        return this.http.get("/api/heroes")
            .then(response => response.data);
    }

    getById(id) {
        return this.http.get(`/api/heroes/${id}`)
            .then(response => response.data);
    }
}