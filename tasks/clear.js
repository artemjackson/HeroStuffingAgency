"use strict";

import config from "./config.json";
import del from "del";

export default function () {
   return del([
       config.publicPath + "*",
       "!" + config.publicPath + "index.html"
   ])
};