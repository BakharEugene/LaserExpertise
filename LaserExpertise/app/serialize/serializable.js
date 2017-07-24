"use strict";
class SerializationHelper {
    static toInstance(obj, json) {
        var jsonObj = JSON.parse(json);
        if (typeof obj["fromJSON"] === "function") {
            obj["fromJSON"](jsonObj);
        }
        else {
            for (var propName in jsonObj) {
                obj[propName] = jsonObj[propName];
            }
        }
        return obj;
    }
}
exports.SerializationHelper = SerializationHelper;
//# sourceMappingURL=serializable.js.map