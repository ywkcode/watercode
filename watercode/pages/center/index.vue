<template>
	<view>
      
	
		<gauge :testdata="mytestdata"></gauge>
		  <view class="u-padding-40">水质</view>
		<view class="mytag">
			<u-tag text="TOC(5mg/l)" type="warning" class="mytab_inner"></u-tag>
			<u-tag text="氨氮( 5mg/l)" type="warning" class="mytab_inner"></u-tag>
			<u-tag text="总磷(4mg/L)" type="warning" class="mytab_inner"></u-tag>
			<u-tag text="PH(0-14.000)" type="warning" class="mytab_inner"></u-tag>
			<u-tag text="流量(0-5000.000)" type="warning" class="mytab_inner"></u-tag>

		</view>
 <view class="u-padding-40">废气</view>
		<view class="mytag">
			<u-tag text="硫化氢（0-30mg/m3）" type="error" class="mytab_inner"></u-tag>
			<u-tag text="氯化氢(0-5mg/m3)" type="error" class="mytab_inner"></u-tag>
			<u-tag text="氯气（0-15mg/m3）" type="error" class="mytab_inner"></u-tag>
			<u-tag text="氨气（0-90mg/m3）" type="error" class="mytab_inner"></u-tag>


		</view>
		<view class="u-padding-40">实时折线图</view>
		<myarea :testdata="mytestdata"></myarea>
		<view class="u-padding-40">实时监测数据</view>
		<mytable></mytable>

	</view>
</template>

<script>
	export default {
		data() {
			return {
				title: 'Hello',
				chartData: {
					categories: [],
					series: [],
				},
				mytestdata: {
					title: '测试1'
				},
				opts: {},
				list: ['TOC(5mg/l)', '氨氮( 5mg/l)', '总磷(4mg/L)', 'PH(0-14.000)', '流量(0-5000.000)'],
				// 或者如下，也可以配置keyName参数修改对象键名
				// list: [{name: '未付款'}, {name: '待评价'}, {name: '已付款'}],
				current: 1,

			}
		},
		onLoad() {

		},
		onReady() {
			//调用绘制方法
			this.mytestdata = {
				title: 'ceshi'
			}

		},

		methods: {
			click(item) {
				console.log('item', item);
			}

		},

		mounted() {

		}
	}
</script>

<style lang="scss" scoped>
	@mixin flexCenter {
		display: flex;
		justify-content: center;
		align-items: center;
	}

	.mytag {
		padding: 0 60rpx 0 60rpx;
	}

	.mytab_inner {
		margin: 0 10rpx 10rpx 0;
	}

	.content {
		width: 100%;
		height: 100%;
		background: #fff;

		.warnInfo {
			width: 100%;
			height: 300upx;
			background: #132040;

			font-size: 30upx;
			color: #fff;

			.warn_title {
				width: 100%;
				height: 60upx;
				line-height: 60upx;
				text-align: left;
				background: #182951;
				padding: 0 40upx;
				box-sizing: border-box;
			}

			.warn_echart {
				width: 100%;
				padding: 0 40upx;
				box-sizing: border-box;
				height: calc(100% - 60upx) !important;
				color: #fff;

				.charts_box {
					width: 100%;
					height: 100%;
				}
			}
		}
	}
</style>
