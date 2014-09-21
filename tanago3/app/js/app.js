function max4(a, b, c, d) {
    return [a, b, c, d].reduce(function (prev, current) {
        if (prev > current) {
            return prev;
        }
        return current;
    });
}
function max() {
    for (var i = 0, args = []; i < arguments.length; i++) args[i] = arguments[i];
    return args.reduce(function (prev, current) {
        if (prev > current) {
            return prev;
        }
        return current;
    });
}
function min() {
    for (var i = 0, args = []; i < arguments.length; i++) args[i] = arguments[i];
    return args.reduce(function (prev, current) {
        if (prev < current) {
            return prev;
        }
        return current;
    });
}
function min3(a, b, c) {
    return min(a, b, c);
}
function min4(a, b, c, d) {
    return min(a, b, c, d);
}

function med3(a,b,c) {
    var mx = max(a,b,c);
    var mn = min(a,b,c);
    if(mx==mn) return mx;
    var map = [];
    var result = [a,b,c].filter(function(elem){
        map[elem] = (map[elem])? map[elem] + 1 : 1;
        return elem != mx && elem != mn;
    });
    if(result.length == 0) {
        for(key in map){
            if(map[key] == 2){
                return parseInt(key);
            }
        }
    }
    return result[0];
}

function med3_2(a,b,c) {
    var mx = max(a,b,c);
    var mn = min(a,b,c);
    if(mx==mn) return mx;

    var arr = [a,b,c];
    for(var i=0; i<arr.length; i++) {
        if(mx == arr[i]) {
            arr.splice(i, 1);
            break;
        }
    }
    for(var j=0; j<arr.length; j++) {
        if(mn == arr[j]) {
            arr.splice(j, 1);
            break;
        }
    }
    return arr[0];
}

function practice1_6(n){
    var i=0;
    while(i<=n){
        i++;
    }
    return i;
}

function practice1_7(){
    var i = 1;
    var sum = 0;
    while(i<=7) {
        sum = sum + i;
    }
    return sum;
}