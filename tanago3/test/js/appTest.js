describe("演習1-1", function(){
    it("4つの引数の最大値を返す", function(){
        result = max4(1,3,2,4);
        expect(result).toEqual(4);

        result = max4(1,2,3,4);
        expect(result).toEqual(4);
    });
});

describe("演習1-2", function(){
    it("3つの引数の最小値を返す", function(){
        result = min3(1,3,2);
        expect(result).toEqual(1);

        result = min3(4,2,3);
        expect(result).toEqual(2);
    });
});

describe("演習1-3", function(){
    it("4つの引数の最小値を返す", function(){
        result = min4(1,3,2,4);
        expect(result).toEqual(1);

        result = min4(6,5,3,8);
        expect(result).toEqual(3);
    });
});

describe("演習1-4", function(){
    it("3つの引数の中央値を返す", function(){
        result = med3_2(1,3,2);
        expect(result).toEqual(2);

        result = med3_2(2,3,4);
        expect(result).toEqual(3);

        result = med3_2(3,3,3);
        expect(result).toEqual(3);

        result = med3_2(3,3,4);
        expect(result).toEqual(3);

        result = med3_2(3,4,4);
        expect(result).toEqual(4);
    });
});

describe("演習1-6", function(){
    result = practice1_6(4);
    expect(result).toEqual(5);
    // マイナスは動かない
//    result = practice1_6(-3);
//    expect(result).toEqual(-2);
});

describe("演習1-7", function(){
    var result = practice1_7();
    expect(result).toEqual(2);
});





