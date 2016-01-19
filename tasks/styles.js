"use strict";

import concat from "gulp-concat";
import config from "./config.json";
import gulp from "gulp";
import less from "gulp-less";
import minifyCss from "gulp-minify-css";

export default function () {
    return gulp.src(config.styles.src)
        .pipe(less())
        .pipe(minifyCss())
        .pipe(concat(config.styles.dest))
        .pipe(gulp.dest(config.publicPath));
};