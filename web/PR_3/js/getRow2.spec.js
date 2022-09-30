const { getRowWithDivider } = require('./getRow')

describe('getRowWithDivider', () => {
	it.each`
		firstValue          | secondValue               | result
		${'мама мыла раму'} | ${'собака друг человека'} | ${'мама мыла раму'}
		${'ааа'}            | ${'АААА'}                 | ${'АААА'}
		${'АаАбвгд'}        | ${'абвгд'}                | ${'АаАбвгд'}
		${''}               | ${'абвгд'}                | ${null}
		${'абвгд'}          | ${''}                     | ${null}
		${''}               | ${''}                     | ${null}
		${'alphatestsfa'}   | ${'aalphaa'}              | ${'aalphaa'}
		${'aalphaa'}        | ${'alphatestsfa'}         | ${'aalphaa'}
		${'abaa'}           | ${'acaa'}                 | ${'abaa'}
		${'aAlpha'}         | ${'alpha'}                | ${'aAlpha'}
	`(
		'getRowWithDivider with firstValue = $firstValue and secondValue = $secondValue should return $result ',
		({ firstValue, secondValue, result }) => {
			expect(getRowWithDivider(firstValue, secondValue, ['a', 'а'])).toBe(
				result
			)
		}
	)
})
