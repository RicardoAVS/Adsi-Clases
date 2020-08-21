const jsonOne = {
  state: 'MT',
  'state-bird': 'Western Meadowloark',
  'state-fish': 'Cutthroat Trout',
  breweries: [
    {
      name: 'Madison River Brewing',
      location: {
        address: '20900 Frontage Rd Building B',
        city: 'Belgrade',
        state: 'MT',
        'zip-code': '59714',
        GPS: {
          lat: 45.44,
          long: 111.04,
        },
      },
      'food-available': false,
      beers: [
        {
          name: 'Salmon Fly Honey Rye',
          color: 'Gold',
          'international-bitterness-units': 12,
          'alcohol-by-volume': 0.04,
        },
        {
          name: 'Copper John Scotch Ale',
          color: 'Copper',
          'international-bitterness-units': 35,
          'alcohol-by-volume': 0.055,
        },
        {
          name: 'Dropper IPA',
          color: 'Amber',
          'international-bitterness-units': 108,
          'alcohol-by-volume': 0.065,
        },
      ],
    },
    {
      name: 'Bozeman Brewing',
      location: {
        address: '504 N. Broadway',
        city: 'Bozeman',
        state: 'MT',
        'zip-code': '59715',
        GPS: {
          lat: 45.64,
          long: 111.02,
        },
      },
      'food-available': true,
      beers: [
        {
          name: 'Bozone Amber Ale',
          color: 'Amber',
          'international-bitterness-units': 29,
          'alcohol-by-volume': 0.054,
        },
        {
          name: 'Plum Street Porter',
          color: 'Dark',
          'international-bitterness-units': 52,
          'alcohol-by-volume': 0.06,
        },
      ],
    },
  ],
};

const jsonTwo = {
  state: 'MT',
  'state-bird': 'Western Meadowloark',
  'state-fish': 'Cutthroat Trout',
  breweries: [
    {
      name: 'Madison River Brewing',
      location: {
        address: '20900 Frontage Rd Building B',
        city: 'Belgrade',
        state: 'MT',
        'zip-code': '59714',
        GPS: {
          lat: 45.44,
          long: 111.04,
        },
      },
      'food-available': false,
      beers: [
        {
          name: 'Salmon Fly Honey Rye',
          color: 'Gold',
          'international-bitterness-units': 12,
          'alcohol-by-volume': 0.04,
        },
        {
          name: 'Copper John Scotch Ale',
          color: 'Copper',
          'international-bitterness-units': 35,
          'alcohol-by-volume': 0.055,
        },
        {
          name: 'Dropper IPA',
          color: 'Amber',
          'international-bitterness-units': 108,
          'alcohol-by-volume': 0.065,
        },
      ],
    },
    {
      name: 'Bozeman Brewing',
      location: {
        address: '504 N. Broadway',
        city: 'Bozeman',
        state: 'MT',
        'zip-code': '59715',
        GPS: {
          lat: 45.64,
          long: 111.02,
        },
      },
    },
  ],
};

let firstJsonKeysList = [];
let firstJsonValueList = [];
let secondJsonKeyList = [];
let secondJsonValueList = [];
let totalCount = 0;
let goodValCount = 0;

function getFirstJsonKeyAndVal(firstJson) {
  Object.keys(firstJson).forEach((key) => {
    // Count and Store JSON Keys in Array
    if (typeof firstJson[key] === 'object') {
      compareJSON(firstJson[key]);
    } else {
      firstJsonKeysList.push(key);
      firstJsonValueList.push(firstJson[key]);
    }
  });
}

function getSecondJsonKeyAndVal(secondJson) {
  Object.keys(secondJson).forEach((key) => {
    // Count and Store JSON Keys in Array
    if (typeof secondJson[key] === 'object') {
      storeJson(secondJson[key]);
    } else {
      secondJsonKeyList.push(key);
      secondJsonValueList.push(secondJson[key]);
    }
  });
}

// return true if both elements are exactly the same
function comparePrimitiveType(firstElement, secondElement) {
  let numOfOcurrencies = 0;

  if (firstElement.length !== secondElement.length) {
    return false;
  } else if (
    typeof firstElement === 'string' &&
    typeof secondElement === 'string'
  ) {
    for (let index = 0; index < firstElement.length; index++) {
      if (firstElement[index] === secondElement[index]) {
        numOfOcurrencies++;
      }
    }
  } else if (typeof firstElement === typeof secondElement) {
    if (firstElement === secondElement) {
      return true;
    }
  }

  return numOfOcurrencies === firstElement.length;
}

/* Compare key & values for both JSON 

	@goodValCount = Number of Key:Value what are identical
  @totalCount = Total Number of Key:Value pair in the Object 
*/
function compare(arr) {
  for (let index in arr) {
    if (
      comparePrimitiveType(firstJsonKeysList[index], secondJsonKeyList[index])
    ) {
      if (
        comparePrimitiveType(
          firstJsonValueList[index],
          secondJsonValueList[index]
        )
      ) {
        goodValCount++;
        totalCount++;
      } else {
        totalCount++;
      }
    } else {
      totalCount++;
    }
  }

  console.log(goodValCount);
  console.log(totalCount);
  let average = (goodValCount * 100) / totalCount; // Drops a % of how identical are both Objects
  let result = totalCount === goodValCount ? 1 : 0; // throw 1 if both JSON are equal or 0 if not
  console.log('Result = ' + result);
  console.log(prom + '%');
}

// Stores Key:Value in corresponding Array
getfirstJsonKeyAndVal(jsonOne);
getSecondJsonKeyAndVal(jsonTwo);

// Makes sure to loop through the correct Object. to avoid OutOfBoundException
if (firstJsonKeysList.length >= secondJsonKeyList.length) {
  compare(secondJsonKeyList);
} else {
  compare(firstJsonKeysList);
}
