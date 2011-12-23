package org.yared.calculator;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.webkit.WebView;
import android.widget.Button;

public class CalcualatorActivity extends Activity {

	private WebView mWebView;
	private StringBuilder mMathString;
	private ButtonClickListener mClickListener;

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.main);

		// Create the math string
		mMathString = new StringBuilder();

		// Enable javascript for the view
		mWebView = (WebView) findViewById(R.id.webview);
		mWebView.getSettings().setJavaScriptEnabled(true);

		// Set the listener for all the buttons
		mClickListener = new ButtonClickListener();
		int idList[] = { R.id.button0, R.id.button1, R.id.button2,
				R.id.button3, R.id.button4, R.id.button5, R.id.button6,
				R.id.button7, R.id.button8, R.id.button9, R.id.buttonLeftParen,
				R.id.buttonRightParen, R.id.buttonPlus, R.id.buttonPlus,
				R.id.buttonMinus, R.id.buttonDivide, R.id.buttonTimes,
				R.id.buttonDecimal, R.id.buttonBackspace, R.id.buttonClear };

		for (int id : idList) {
			View v = findViewById(id);
			v.setOnClickListener(mClickListener);
		}

	}

	private void updateWebView() {

		StringBuilder builder = new StringBuilder();

		builder.append("<html><body>");
		builder.append("<script type=\"text/javascript\">document.write('");
		builder.append(mMathString.toString());
		builder.append("');");
		builder.append("document.write('<br />=' + eval(\"");
		builder.append(mMathString.toString());
		builder.append("\"));</script>");
		builder.append("</body></html>");

		mWebView.loadData(builder.toString(), "application/xhtml", "UTF-8");
	}

	private class ButtonClickListener implements OnClickListener {

		@Override
		public void onClick(View v) {
			switch (v.getId()) {
			case R.id.buttonBackspace:
				if (mMathString.length() > 0)
					mMathString.deleteCharAt(mMathString.length() - 1);
				break;
			case R.id.buttonClear:
				if (mMathString.length() > 0)
					mMathString.delete(0, mMathString.length());
				break;
			default:
				mMathString.append(((Button) v).getText());
			}

			updateWebView();
		}
	}
}
