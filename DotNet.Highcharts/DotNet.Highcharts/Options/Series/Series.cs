using System;
using System.Drawing;
using DotNet.Highcharts.Attributes;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options.PlotOptions;

namespace DotNet.Highcharts.Options.Series
{
	/// <summary>
	/// The actual series to append to the chart. In addition to the members listed below, any member of the <code>plotOptions</code> for that specifictype of plot can be added to a series individually. For example, even though a general<code>lineWidth</code> is specified in <code>plotOptions.series</code>, an individual<code>lineWidth</code> can be specified for each series.
	/// </summary>
	public class Series
	{
		/// <summary>
		/// An array of data points for the series. The points can be given in three ways: <ol> <li>An array of numerical values. In this case, the numberical values will  be interpreted and y values, and x values will be automatically calculated, either starting at 0 and incrementing by 1, or from <code>pointStart</code>  and <code>pointInterval</code> given in the plotOptions. If the axis is has categories, these will be used. This option is not available for range series. Example:<pre>data: [0, 5, 3, 5]</pre> </li> <li><p>An array of arrays with two values. In this case, the first value is the x value and the second is the y value. If the first value is a string, it is applied as the name of the point, and the x value is incremented following the above rules.</p><p>For range series, the arrays will be interpreted as <code>[x, low, high]</code>. In this cases, the X value can be skipped altogether to make use of <code>pointStart</code> and <code>pointRange</code>.</p> Example:<pre>data: [[5, 2], [6, 3], [8, 2]]</pre></li><li><p>An array of objects with named values. In this case the objects are point configuration objects as seen below.</p><p>Range series values are given by <code>low</code> and <code>high</code>.</p>Example:<pre>data: [{ name: 'Point 1', color: '#00FF00', y: 0}, { name: 'Point 2', color: '#FF00FF', y: 5}]</pre></li> </ol>
		/// </summary>
		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public Data Data { get; set; }

		[Obsolete("This method is deprecated as of version 2.0. Instead, use options preprocessing as described in <a href='http://docs.highcharts.com/#preprocessing'>the docs</a>.")]
		[JsonFormatter("{0}")]
		public string DataParser { get; set; }

		[Obsolete("This method is deprecated as of version 2.0. Instead, load the data using jQuery.ajax and use options preprocessing as described in <a href='http://docs.highcharts.com/#preprocessing'>the docs</a>.")]
		public string DataURL { get; set; }

		/// <summary>
		/// The index of the series in the chart, affecting the internal index in the <code>chart.series</code> array, the visible Z index as well as the order in the legend.
		/// </summary>
		public Number? Index { get; set; }

		/// <summary>
		/// The sequential index of the series in the legend.  <div class='demo'>Try it:  <a href='http://jsfiddle.net/gh/get/jquery/1.7.1/highslide-software/highcharts.com/tree/master/samples/highcharts/series/legendindex/' target='_blank'>Legend in opposite order</a> </div>.
		/// </summary>
		public Number? LegendIndex { get; set; }

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The column size - how many X axis units each column in the heatmap should span.
		/// </summary>
		public Number? Colsize { get; set; }

	    /// <summary>
	    /// The row size - how many Y axis units each heatmap row should span.
	    /// </summary>
	    public Number? Rowsize { get; set; }

        /// <summary>
        /// The width of the border surrounding each column or bar. Defaults to 1 when there is room for a border, but to 0 when the columns are so dense that a border would cover the next column.
        /// </summary>
	    public Number? BorderWidth { get; set; }

		/// <summary>
		/// The color applied to null points.
		/// </summary>
		public Color? NullColor { get; set; }

        /// <summary>
        /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to 0 disable.
        /// </summary>
	    public Number? TurboThreshold { get; set; }

        /// <summary>
        /// Set the point threshold for when a series should enter boost mode.
        /// Setting it to e.g. 2000 will cause the series to enter boost mode when there are 2000 or more points in the series.
        /// To disable boosting on the series, set the boostThreshold to 0. Setting it to 1 will force boosting.
        /// </summary>
	    public Number? BoostThreshold { get; set; }

	    /// <summary>
		/// A configuration object for the tooltip rendering of each single series.
		/// </summary>
		public Tooltip Tooltip { get; set; }

		/// <summary>
		/// Whether to display this particular series or series type in the legend. The default value is true for standalone series, false for linked series.
		/// Default: true
		/// </summary>
		public bool? ShowInLegend { get; set; }

		/// <summary>
		/// This option allows grouping series in a stacked chart. The stack option can be a string  or a number or anything else, as long as the grouped series' stack options match each other.
		/// </summary>
		public string Stack { get; set; }

		/// <summary>
		/// The type of series. Can be one of <code>area</code>, <code>areaspline</code>, <code>bar</code>, <code>column</code>, <code>line</code>, <code>pie</code>, <code>scatter</code> or <code>spline</code>. From version 2.3, <code>arearange</code>, <code>areasplinerange</code> and <code>columnrange</code> are supported with the highcharts-more.js component.
		/// </summary>
		public ChartTypes? Type { get; set; }

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis the particular series is connected to. It refers to either the <a href='#xAxis.id'>axis id</a> or the index of the axis in the xAxis array, with 0 being the first.
		/// Default: 0
		/// </summary>
		public string XAxis { get; set; }

		/// <summary>
		/// When using dual or multiple x axes, this number defines which yAxis the particular series is connected to. It refers to either the <a href='#yAxis.id'>axis id</a> or the index of the axis in the yAxis array, with 0 being the first.
		/// Default: 0
		/// </summary>
		public string YAxis { get; set; }

		public Color? Color { get; set; }

		public Color? UpColor { get; set; }

	    public bool? DraggableX { get; set; }
	    public bool? DraggableY { get; set; }
	    public double? DragMaxX { get; set; }
	    public double? DragMaxY { get; set; }
	    public double? DragMinX { get; set; }
	    public double? DragMinY { get; set; }
	    public double? DragPrecisionX { get; set; }
	    public double? DragPrecisionY { get; set; }
	    public Point Point { get; set; }

		/// <summary>
		/// Gets or sets the series' visibility state.
		/// Default: null, means visible.
		/// </summary>
		public bool? Visible { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsArea PlotOptionsArea { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsAreaspline PlotOptionsAreaspline { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsBar PlotOptionsBar { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsColumn PlotOptionsColumn { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsLine PlotOptionsLine { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsSpline PlotOptionsSpline { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsPie PlotOptionsPie { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsSeries PlotOptionsSeries { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsScatter PlotOptionsScatter { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsArearange PlotOptionsArearange { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsAreasplinerange PlotOptionsAreasplinerange { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsColumnrange PlotOptionsColumnrange { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsGauge PlotOptionsGauge { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsBoxplot PlotOptionsBoxplot { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsWaterfall PlotOptionsWaterfall { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsFunnel PlotOptionsFunnel { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsBubble PlotOptionsBubble { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsOhlc PlotOptionsOhlc { get; set; }

		[JsonFormatter(addPropertyName: false, useCurlyBracketsForObject: false)]
		public PlotOptionsFlags PlotOptionsFlags { get; set; }
	}

}
